using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hotel_Booking_System
{
    public class CustomCalendarControl : Panel
    {
        // ── State ──────────────────────────────────────────────────────────────
        private DateTime? _checkIn  = null;
        private DateTime? _checkOut = null;
        private DateTime  _displayMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        private bool      _isSelectingCheckOut = false;
        private DateTime? _hoveredDate = null;

        // ── Layout constants ──────────────────────────────────────────────────
        private const int HeaderHeight    = 52;
        private const int DayHeaderHeight = 34;
        private const int FooterHeight    = 94;

        // ── Header controls ───────────────────────────────────────────────────
        private Panel  pnlHeader     = null!;
        private Button btnPrevMonth  = null!;
        private Button btnNextMonth  = null!;
        private Label  lblMonthTitle = null!;

        // ── Footer controls ───────────────────────────────────────────────────
        private Panel  pnlFooter        = null!;
        private Label  lblStaySummary   = null!;
        private Button btnApply          = null!;
        private Button btnPresetTonight  = null!;
        private Button btnPresetWeekend  = null!;

        // ── Public events ──────────────────────────────────────────────────────
        public event EventHandler<EventArgs>? DatesChanged;
        public event EventHandler<EventArgs>? CloseRequested;

        // ── Public properties ─────────────────────────────────────────────────
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public DateTime CheckInDate
        {
            get => _checkIn ?? DateTime.Today;
            set
            {
                _checkIn = value.Date;
                if (_checkOut.HasValue && _checkOut.Value <= _checkIn.Value)
                    _checkOut = _checkIn.Value.AddDays(1);
                UpdateSummaryText();
                Invalidate();
            }
        }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public DateTime CheckOutDate
        {
            get => _checkOut ?? DateTime.Today.AddDays(1);
            set
            {
                _checkOut = value.Date;
                if (_checkIn.HasValue && _checkOut.Value <= _checkIn.Value)
                    _checkIn = _checkOut.Value.AddDays(-1);
                UpdateSummaryText();
                Invalidate();
            }
        }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int TotalNights
        {
            get
            {
                if (!_checkIn.HasValue || !_checkOut.HasValue) return 0;
                return Math.Max(1, (_checkOut.Value - _checkIn.Value).Days);
            }
        }

        // ── Constructor ───────────────────────────────────────────────────────
        public CustomCalendarControl()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(500, 510);
            this.BackColor = Color.White;

            InitializeControls();
            UpdateMonthTitle();
            UpdateSummaryText();
        }

        // ── Build child controls ──────────────────────────────────────────────
        private void InitializeControls()
        {
            // ── Header Bar ────────────────────────────────────────────────────
            pnlHeader = new Panel
            {
                Dock      = DockStyle.Top,
                Height    = HeaderHeight,
                BackColor = Color.FromArgb(23, 45, 80)
            };

            btnPrevMonth = new Button
            {
                Text      = "◀",
                Font      = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Size      = new Size(52, HeaderHeight),
                Location  = new Point(0, 0),
                Cursor    = Cursors.Hand
            };
            btnPrevMonth.FlatAppearance.BorderSize = 0;
            btnPrevMonth.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 75, 125);
            btnPrevMonth.Click += (s, e) => NavigateMonth(-1);

            btnNextMonth = new Button
            {
                Text      = "▶",
                Font      = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Size      = new Size(52, HeaderHeight),
                Location  = new Point(this.Width - 52, 0),
                Anchor    = AnchorStyles.Top | AnchorStyles.Right,
                Cursor    = Cursors.Hand
            };
            btnNextMonth.FlatAppearance.BorderSize = 0;
            btnNextMonth.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 75, 125);
            btnNextMonth.Click += (s, e) => NavigateMonth(1);

            lblMonthTitle = new Label
            {
                Text      = "November 2026",
                Font      = new Font("Segoe UI", 13.5F, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Location  = new Point(54, 0),
                Size      = new Size(this.Width - 108, HeaderHeight),
                Anchor    = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            pnlHeader.Resize += (s, e) =>
            {
                btnNextMonth.Left  = pnlHeader.Width - 52;
                lblMonthTitle.Width = Math.Max(50, pnlHeader.Width - 108);
            };

            pnlHeader.Controls.Add(btnPrevMonth);
            pnlHeader.Controls.Add(btnNextMonth);
            pnlHeader.Controls.Add(lblMonthTitle);
            this.Controls.Add(pnlHeader);

            // ── Footer Bar ────────────────────────────────────────────────────
            pnlFooter = new Panel
            {
                Dock      = DockStyle.Bottom,
                Height    = FooterHeight,
                BackColor = Color.FromArgb(248, 250, 252)
            };
            pnlFooter.Paint += (s, e) =>
            {
                using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    e.Graphics.DrawLine(borderPen, 0, 0, pnlFooter.Width, 0);
                }
            };

            lblStaySummary = new Label
            {
                Text      = "🌙 Select dates",
                Font      = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(23, 45, 80),
                Location  = new Point(16, 12),
                AutoSize  = true
            };

            btnPresetTonight = new Button
            {
                Text      = "+1 Night",
                Font      = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(23, 45, 80),
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size      = new Size(110, 36),
                Location  = new Point(16, 44),
                Cursor    = Cursors.Hand
            };
            btnPresetTonight.FlatAppearance.BorderColor = Color.FromArgb(200, 215, 230);
            btnPresetTonight.Click += (s, e) =>
            {
                _checkIn  = DateTime.Today;
                _checkOut = DateTime.Today.AddDays(1);
                _isSelectingCheckOut = false;
                _displayMonth = new DateTime(_checkIn.Value.Year, _checkIn.Value.Month, 1);
                UpdateMonthTitle();
                UpdateSummaryText();
                Invalidate();
                DatesChanged?.Invoke(this, EventArgs.Empty);
            };

            btnPresetWeekend = new Button
            {
                Text      = "Weekend",
                Font      = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(23, 45, 80),
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size      = new Size(110, 36),
                Location  = new Point(136, 44),
                Cursor    = Cursors.Hand
            };
            btnPresetWeekend.FlatAppearance.BorderColor = Color.FromArgb(200, 215, 230);
            btnPresetWeekend.Click += (s, e) =>
            {
                DateTime nextFriday = DateTime.Today;
                while (nextFriday.DayOfWeek != DayOfWeek.Friday)
                    nextFriday = nextFriday.AddDays(1);
                _checkIn  = nextFriday;
                _checkOut = nextFriday.AddDays(2);
                _isSelectingCheckOut = false;
                _displayMonth = new DateTime(_checkIn.Value.Year, _checkIn.Value.Month, 1);
                UpdateMonthTitle();
                UpdateSummaryText();
                Invalidate();
                DatesChanged?.Invoke(this, EventArgs.Empty);
            };

            btnApply = new Button
            {
                Text      = "Done ✓",
                Font      = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(23, 45, 80),
                FlatStyle = FlatStyle.Flat,
                Size      = new Size(110, 38),
                Location  = new Point(this.Width - 126, 43),
                Anchor    = AnchorStyles.Top | AnchorStyles.Right,
                Cursor    = Cursors.Hand
            };
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 75, 125);
            btnApply.Click += (s, e) => CloseRequested?.Invoke(this, EventArgs.Empty);

            pnlFooter.Resize += (s, e) =>
            {
                btnApply.Left = pnlFooter.Width - btnApply.Width - 16;
            };

            pnlFooter.Controls.Add(lblStaySummary);
            pnlFooter.Controls.Add(btnPresetTonight);
            pnlFooter.Controls.Add(btnPresetWeekend);
            pnlFooter.Controls.Add(btnApply);
            this.Controls.Add(pnlFooter);
        }

        // ── Month navigation ──────────────────────────────────────────────────
        private void NavigateMonth(int delta)
        {
            DateTime next = _displayMonth.AddMonths(delta);
            DateTime currentRealMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            if (delta < 0 && next < currentRealMonth) return;
            _displayMonth = next;
            UpdateMonthTitle();
            Invalidate();
        }

        private void UpdateMonthTitle()
        {
            if (lblMonthTitle == null) return;
            lblMonthTitle.Text = _displayMonth.ToString("MMMM yyyy");

            DateTime currentRealMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            bool canGoPrev = (_displayMonth > currentRealMonth);
            btnPrevMonth.Enabled  = canGoPrev;
            btnPrevMonth.ForeColor = canGoPrev ? Color.White : Color.FromArgb(100, 120, 150);
        }

        private void UpdateSummaryText()
        {
            if (lblStaySummary == null) return;
            if (!_checkIn.HasValue || !_checkOut.HasValue)
            {
                lblStaySummary.Text = "🌙 Select dates";
                return;
            }
            int nights = TotalNights;
            string nightStr = nights == 1 ? "1 night" : $"{nights} nights";
            string dayStr   = (nights + 1) == 1 ? "1 day" : $"{nights + 1} days";
            lblStaySummary.Text = $"🌙 {nightStr} stay ({dayStr})";
        }

        // ── Paint ─────────────────────────────────────────────────────────────
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode        = SmoothingMode.AntiAlias;
            g.TextRenderingHint    = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            float colWidth    = (float)this.Width / 7f;
            float dayHeaderY  = HeaderHeight;

            // ── Day-of-Week row ───────────────────────────────────────────────
            using (SolidBrush headerBg = new SolidBrush(Color.FromArgb(241, 245, 249)))
                g.FillRectangle(headerBg, 0, dayHeaderY, this.Width, DayHeaderHeight);

            string[] dayNames = { "Mo", "Tu", "We", "Th", "Fr", "Sa", "Su" };
            using (Font dayFont  = new Font("Segoe UI", 9.5F, FontStyle.Bold))
            using (SolidBrush dayBrush = new SolidBrush(Color.FromArgb(100, 116, 139)))
            {
                for (int i = 0; i < 7; i++)
                {
                    RectangleF r  = new RectangleF(i * colWidth, dayHeaderY, colWidth, DayHeaderHeight);
                    StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString(dayNames[i], dayFont, dayBrush, r, sf);
                }
            }

            // ── Date grid ─────────────────────────────────────────────────────
            float gridTop    = HeaderHeight + DayHeaderHeight;
            float gridHeight = this.Height - gridTop - FooterHeight;
            float rowHeight  = gridHeight / 6f;

            int      daysInMonth = DateTime.DaysInMonth(_displayMonth.Year, _displayMonth.Month);
            DateTime firstDay    = new DateTime(_displayMonth.Year, _displayMonth.Month, 1);
            int      startOffset = ((int)firstDay.DayOfWeek + 6) % 7; // Monday = 0

            // Comfortable 38px circle diameter
            float circleSize = 38f;

            using (Font cellFont   = new Font("Segoe UI", 11F,   FontStyle.Regular))
            using (Font boldFont   = new Font("Segoe UI", 11F,   FontStyle.Bold))
            using (Font badgeFont  = new Font("Segoe UI", 7.5F,  FontStyle.Bold))
            using (SolidBrush textBrush     = new SolidBrush(Color.FromArgb(30,  41,  59)))
            using (SolidBrush disabledBrush = new SolidBrush(Color.FromArgb(203, 213, 225)))
            using (SolidBrush whiteBrush    = new SolidBrush(Color.White))
            using (SolidBrush navyBrush     = new SolidBrush(Color.FromArgb(23,  45,  80)))
            using (SolidBrush goldBrush     = new SolidBrush(Color.FromArgb(212, 160,  10)))
            using (SolidBrush rangeBrush    = new SolidBrush(Color.FromArgb(226, 238, 252)))
            using (Pen        hoverPen      = new Pen(Color.FromArgb(70, 130, 210), 2))
            {
                for (int day = 1; day <= daysInMonth; day++)
                {
                    int cellIndex = startOffset + day - 1;
                    int col       = cellIndex % 7;
                    int row       = cellIndex / 7;

                    RectangleF cellRect = new RectangleF(
                        col * colWidth,
                        gridTop + row * rowHeight,
                        colWidth,
                        rowHeight);

                    DateTime cellDate  = new DateTime(_displayMonth.Year, _displayMonth.Month, day);
                    bool isPast     = cellDate < DateTime.Today;
                    bool isCheckIn  = _checkIn.HasValue  && cellDate == _checkIn.Value;
                    bool isCheckOut = _checkOut.HasValue && cellDate == _checkOut.Value;
                    bool isInRange  = _checkIn.HasValue && _checkOut.HasValue
                                      && cellDate > _checkIn.Value && cellDate < _checkOut.Value;
                    bool isHovered  = _hoveredDate.HasValue && _hoveredDate.Value == cellDate;

                    // Centered circle with 4px drop for badge headroom
                    float circleX = cellRect.X + (cellRect.Width - circleSize) / 2f;
                    float circleY = cellRect.Y + (cellRect.Height - circleSize) / 2f + 4f;

                    // ── 1. Range highlight strip (rendered behind circle) ─────
                    float stripY = circleY + 3f;
                    float stripH = circleSize - 6f;

                    if (isInRange)
                    {
                        g.FillRectangle(rangeBrush, cellRect.X, stripY, cellRect.Width, stripH);
                    }
                    else if (isCheckIn && _checkOut.HasValue && _checkIn.HasValue && _checkOut.Value > _checkIn.Value)
                    {
                        float startX = circleX + circleSize / 2f;
                        g.FillRectangle(rangeBrush, startX, stripY, cellRect.Right - startX, stripH);
                    }
                    else if (isCheckOut && _checkIn.HasValue && _checkOut.HasValue && _checkIn.Value < _checkOut.Value)
                    {
                        float endX = circleX + circleSize / 2f;
                        g.FillRectangle(rangeBrush, cellRect.X, stripY, endX - cellRect.X, stripH);
                    }

                    // ── 2. Solid Circle for Check-In / Check-Out or Hover outline ──
                    if (isCheckIn || isCheckOut)
                    {
                        g.FillEllipse(navyBrush, circleX, circleY, circleSize, circleSize);
                    }
                    else if (isHovered && !isPast)
                    {
                        g.DrawEllipse(hoverPen, circleX, circleY, circleSize, circleSize);
                    }

                    // ── 3. Date number (centered in circle) ───────────────────
                    StringFormat sfCenter = new StringFormat
                    {
                        Alignment     = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    RectangleF numberRect = new RectangleF(circleX, circleY, circleSize, circleSize);

                    Brush dateBrush = isPast
                        ? disabledBrush
                        : (isCheckIn || isCheckOut) ? whiteBrush : textBrush;
                    Font  fontToUse = (isCheckIn || isCheckOut || isInRange) ? boldFont : cellFont;

                    g.DrawString(day.ToString(), fontToUse, dateBrush, numberRect, sfCenter);

                    // ── 4. IN / OUT badge (positioned right above circle) ────────
                    if (isCheckIn || isCheckOut)
                    {
                        RectangleF badgeRect = new RectangleF(cellRect.X, circleY - 14f, cellRect.Width, 14f);
                        string badgeText = isCheckIn ? "IN" : "OUT";
                        g.DrawString(badgeText, badgeFont, goldBrush, badgeRect, sfCenter);
                    }
                }
            }

            // ── Outer border ──────────────────────────────────────────────────
            using (Pen borderPen = new Pen(Color.FromArgb(210, 220, 235), 1))
                g.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
        }

        // ── Mouse interactions ────────────────────────────────────────────────
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            DateTime? hit = HitTestDate(e.Location);
            if (hit != _hoveredDate)
            {
                _hoveredDate = hit;
                this.Cursor  = (hit.HasValue && hit.Value >= DateTime.Today) ? Cursors.Hand : Cursors.Default;
                Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (_hoveredDate.HasValue)
            {
                _hoveredDate = null;
                Invalidate();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button != MouseButtons.Left) return;

            DateTime? hit = HitTestDate(e.Location);
            if (!hit.HasValue || hit.Value < DateTime.Today) return;

            DateTime clicked = hit.Value;

            // ── Deselect if clicking an already-selected date ─────────────────
            if (_checkIn.HasValue && clicked == _checkIn.Value)
            {
                if (_checkOut.HasValue)
                {
                    _checkIn  = _checkOut;
                    _checkOut = null;
                    _isSelectingCheckOut = true;
                }
                else
                {
                    _checkIn = null;
                    _isSelectingCheckOut = false;
                }
                UpdateSummaryText();
                Invalidate();
                DatesChanged?.Invoke(this, EventArgs.Empty);
                return;
            }

            if (_checkOut.HasValue && clicked == _checkOut.Value)
            {
                _checkOut = null;
                _isSelectingCheckOut = true;
                UpdateSummaryText();
                Invalidate();
                DatesChanged?.Invoke(this, EventArgs.Empty);
                return;
            }

            // ── Normal selection flow ─────────────────────────────────────────
            if (!_checkIn.HasValue || !_isSelectingCheckOut)
            {
                _checkIn  = clicked;
                _checkOut = null;
                _isSelectingCheckOut = true;
            }
            else
            {
                if (clicked > _checkIn.Value)
                {
                    _checkOut = clicked;
                    _isSelectingCheckOut = false;
                }
                else
                {
                    // Clicked before current check-in -> restart check-in
                    _checkIn  = clicked;
                    _checkOut = null;
                    _isSelectingCheckOut = true;
                }
            }

            UpdateSummaryText();
            Invalidate();
            DatesChanged?.Invoke(this, EventArgs.Empty);
        }

        // ── Hit-test a pixel to a calendar date ───────────────────────────────
        private DateTime? HitTestDate(Point pt)
        {
            float gridTop    = HeaderHeight + DayHeaderHeight;
            float gridHeight = this.Height - gridTop - FooterHeight;
            if (pt.Y < gridTop || pt.Y > gridTop + gridHeight) return null;

            float colWidth  = (float)this.Width / 7f;
            float rowHeight = gridHeight / 6f;

            int col = (int)(pt.X / colWidth);
            int row = (int)((pt.Y - gridTop) / rowHeight);

            if (col < 0 || col >= 7 || row < 0 || row >= 6) return null;

            int cellIndex = row * 7 + col;
            DateTime firstDay    = new DateTime(_displayMonth.Year, _displayMonth.Month, 1);
            int      startOffset = ((int)firstDay.DayOfWeek + 6) % 7;

            int day          = cellIndex - startOffset + 1;
            int daysInMonth  = DateTime.DaysInMonth(_displayMonth.Year, _displayMonth.Month);

            if (day >= 1 && day <= daysInMonth)
                return new DateTime(_displayMonth.Year, _displayMonth.Month, day);

            return null;
        }
    }
}

﻿namespace Winium.StoreApps.Driver.EmulatorHelpers
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Drawing;

    #endregion

    internal class TapGesture : IGesture
    {
        #region Constructors and Destructors

        public TapGesture(Point tapPoint, TimeSpan tapDuration = default(TimeSpan))
        {
            this.TapPosition = tapPoint;
            this.PeriodBetweenPoints = tapDuration;
        }

        #endregion

        #region Public Properties

        public TimeSpan PeriodBetweenPoints { get; set; }

        public Point TapPosition { get; set; }

        #endregion

        #region Public Methods and Operators

        public IEnumerable<Point> GetScreenPoints()
        {
            return new[] { this.TapPosition, this.TapPosition };
        }

        #endregion
    }
}

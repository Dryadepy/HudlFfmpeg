﻿using System;
using Hudl.Ffmpeg.BaseTypes;
using Hudl.Ffmpeg.Filters.BaseTypes;
using Hudl.Ffmpeg.Resources.BaseTypes;

namespace Hudl.Ffmpeg.Filters
{
    /// <summary>
    /// Changes the PTS (presentation timestamp of the input frames)
    /// </summary>
    [AppliesToResource(Type=typeof(IAudio))]
    public class ASetPts : BaseFilter
    {
        private const int FilterMaxInputs = 1;
        private const string FilterType = "asetpts";
        private const string ResetPtsExpression = "PTS-STARTPTS";
        public const string FormatPlaybackRateExpression = "{0}*PTS"; 

        public ASetPts() 
            : base(FilterType, FilterMaxInputs)
        {
        }
        public ASetPts(string expression)
            : this()
        {
            Expression = expression;
        }
        public ASetPts(bool resetTimestamp)
            : this(ResetPtsExpression)
        {
        }

        /// <summary>
        /// the setpts expression details can be found at http://ffmpeg.org/ffmpeg-all.html#setpts_002c-asetpts
        /// </summary>
        public string Expression { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(Expression))
            {
                throw new InvalidOperationException("Expression cannot be empty with a set PTS filter");
            }

            return string.Concat(Type, "=", Expression);
        }
    }
}

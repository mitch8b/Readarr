﻿using NzbDrone.Core.Repository.Quality;
using SubSonic.SqlGeneration.Schema;

namespace NzbDrone.Core.Model
{
    public class SeasonParseResult
    {
        internal string SeriesTitle { get; set; }
        internal int SeasonNumber { get; set; }
        internal int Year { get; set; }

        public override string ToString()
        {
            return string.Format("Series:{0} Season:{1}", SeriesTitle, SeasonNumber);
        }

    }
}
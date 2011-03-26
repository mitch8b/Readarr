﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NzbDrone.Core.Model;
using NzbDrone.Core.Repository;

namespace NzbDrone.Core.Providers
{
    public interface IRssItemProcessingProvider
    {
        //This interface will contain methods to process individual RSS Feed Items (Queue if wanted)

        void DownloadIfWanted(NzbInfoModel nzb, Indexer indexer);
        string GetTitleFix(List<EpisodeParseResult> episodes, int seriesId);
    }
}

﻿using Hudl.Ffmpeg.BaseTypes;
using Hudl.Ffmpeg.Common;
using Hudl.Ffmpeg.Resources.BaseTypes;
using Hudl.Ffmpeg.Settings.BaseTypes;

namespace Hudl.Ffmpeg.Settings
{
    [AppliesToResource(Type = typeof(IVideo))]
    [AppliesToResource(Type = typeof(IAudio))]
    [SettingsApplication(PreDeclaration = true, ResourceType = SettingsCollectionResourceType.Output)]
    public class RemoveVideo : BaseSetting
    {
        private const string SettingType = "-vn";

        public RemoveVideo()
            : base(SettingType)
        {
        }
        
        public override string ToString()
        {
            return Type;
        }
    }
}

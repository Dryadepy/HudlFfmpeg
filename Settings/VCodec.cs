﻿using System;
using Hudl.Ffmpeg.BaseTypes;
using Hudl.Ffmpeg.Common;
using Hudl.Ffmpeg.Resources.BaseTypes;
using Hudl.Ffmpeg.Settings.BaseTypes;

namespace Hudl.Ffmpeg.Settings
{
    /// <summary>
    /// Video codec for a video resource file.
    /// </summary>
    [AppliesToResource(Type = typeof(IVideo))]
    [SettingsApplication(PreDeclaration = true, ResourceType = SettingsCollectionResourceType.Output)]
    public class VCodec : BaseSetting
    {
        private const string SettingType = "-vcodec";

        public VCodec(string codec)
            : base(SettingType)
        {
            Codec = codec;
        }
        public VCodec(VideoCodecType codec)
            : this(Formats.Library(codec))
        {
        }

        public string Codec { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(Codec))
            {
                throw new InvalidOperationException("Codec cannot be empty for this setting.");
            }

            return string.Concat(Type, " ", Codec);
        }
    }
}

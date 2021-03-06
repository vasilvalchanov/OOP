﻿namespace ReaperInvasion.UI
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    public sealed class AssetLoader
    {
        private static readonly AssetLoader instance = new AssetLoader();

        private Dictionary<AssetType, ImageSource> assets = new Dictionary<AssetType, ImageSource>();

        private AssetLoader()
        {
        }

        public static AssetLoader Instance
        {
            get
            {
                return instance;
            }
        }

        public Image GetImage(AssetType type)
        {
            if (!this.assets.ContainsKey(type))
            {
                this.assets.Add(type, this.LoadImage(type));
            }

            return new Image()
            {
                Source = this.assets[type]
            };
        }

        private ImageSource LoadImage(AssetType type)
        {

            string path = string.Empty;

                switch (type)
                {
                    case AssetType.Reaper:
                        path = AssetPaths.ReaperImage;
                        break;
                    default:
                        throw new ArgumentException("Unsupported asset type.");
                }

                var src = new Uri(path, UriKind.Relative);

                return BitmapFrame.Create(src);
            
        }
    }
}

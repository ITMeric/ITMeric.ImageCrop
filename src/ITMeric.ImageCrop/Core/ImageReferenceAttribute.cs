﻿using System;

namespace ITMeric.ImageCrop.Core
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ImageReferenceAttribute : Attribute
    {
        //public ImageReferenceAttribute(Type[] allowedTypes)
        //{
        //    AllowedTypes = allowedTypes;
        //}

        public double CropRatio { get; set; }
        public Type[] AllowedTypes { get; set; }

    }
}
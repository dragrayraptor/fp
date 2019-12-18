﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagsCloudContainer.UI;

namespace TagsCloudContainer.ImageCreator
{
    public interface IImageCreator
    {
        Result<bool> CreateImage(IInitialSettings settings);
    }
}

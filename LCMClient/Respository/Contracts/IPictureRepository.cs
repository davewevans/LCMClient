﻿using LCMSMSPWA.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LCMClient.Repository.Contracts
{
    public interface IPictureRepository
    {
        Task<string> UploadImageAsync(PictureCreation picCreation, byte[] fileBytes);
    }
}

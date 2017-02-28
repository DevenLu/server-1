﻿using System;
using Bit.Core.Domains;

namespace Bit.Api.Models
{
    public class ShareResponseModel : ResponseModel
    {
        public ShareResponseModel(Share share)
            : base("share")
        {
            if(share == null)
            {
                throw new ArgumentNullException(nameof(share));
            }

            Id = share.Id.ToString();
            UserId = share.UserId.ToString();
            SharerUserId = share.SharerUserId.ToString();
            CipherId = share.CipherId.ToString();
            Key = Key;
            ReadOnly = share.ReadOnly;
            Status = share.Status;
        }

        public string Id { get; set; }
        public string UserId { get; set; }
        public string SharerUserId { get; set; }
        public string CipherId { get; set; }
        public string Key { get; set; }
        public bool ReadOnly { get; set; }
        public Core.Enums.ShareStatusType? Status { get; set; }
    }
}

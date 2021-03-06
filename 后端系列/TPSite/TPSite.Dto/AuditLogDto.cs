﻿using System;
using System.Collections.Generic;
using System.Text;
using TPSite.Dto.Base;

namespace TPSite.Dto
{
    public class AuditLogDto : EntityDto<Guid>
    {
        public Guid? UserId { get; set; }
        public string ServiceName { get; set; }
        public string MethodName { get; set; }
        public string Parameters { get; set; }
        public DateTime ExecutionTime { get; set; }
        public string ClientIpAddress { get; set; }
        public string BrowserInfo { get; set; }
    }
}

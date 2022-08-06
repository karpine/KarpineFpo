using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MessageObject
/// </summary>
/// 
namespace Karpine.Fpo.Domain.Helper
{
    public class MessageObject
    {
        public string UserHash { get; set; }
        public string Schema { get; set; }
        public string SchemaVersion { get; set; }
        public string Prefix { get; set; }
        public string MessageVersion { get; set; }
        public string MessageType { get; set; }
        public string Id { get; set; }
        public string Message { get; set; }
    }
}
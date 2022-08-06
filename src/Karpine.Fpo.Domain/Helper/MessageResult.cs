using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MessageResult
/// </summary>
/// 
namespace Karpine.Fpo.Domain.Helper
{
    public class MessageResult
    {
        public MessageResult()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public string Exception { get; set; }
        public long Gas { get; set; }
        public string Script { get; set; }
        public List<string> ScriptAnalysis { get; set; }
        public string VMState { get; set; }
        public string Message { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TxResult
/// </summary>
/// 
namespace Karpine.Fpo.Domain.Helper
{
    public class TxResult
    {
        public TxResult()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public string Id { get; set; }
        public string Sender { get; set; }
        public string Signer { get; set; }
        public string WitnessScope { get; set; }
        public int Size { get; set; }
        public long NetworkFee { get; set; }
        public long SystemFee { get; set; }
        public uint Nonce { get; set; }
        public uint ValidUntilBlock { get; set; }
        public string Script { get; set; }
        public List<string> ScriptAnalysis { get; set; }
        public string Version { get; set; }
        public long FeePerByte { get; set; }
        public string WitnessInvocation { get; set; }
        public string WitnessVerification { get; set; }
        public List<string> InvocationAnalysis { get; set; }
        public List<string> VerificationAnalysis { get; set; }
    }
}
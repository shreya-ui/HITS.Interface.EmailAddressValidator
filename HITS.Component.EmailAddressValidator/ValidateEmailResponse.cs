using System;
using System.Text.Json;

namespace HITS.Component.EmailAddressValidator
{
    /// <summary>
    /// EmailVerificationModel
    /// </summary>
    /// <remarks>
    ///  {
    ///    "result":"invalid",
    ///    "reason":"rejected_email",
    ///    "disposable":"false",
    ///    "accept_all":"false",
    ///    "role":"false",
    ///    "free":"false",
    ///    "email":"richard@quickemailverification.com",
    ///    "user":"richard",
    ///    "domain":"quickemailverification.com",
    ///    "mx_record":"us2.mx1.mailhostbox.com",
    ///    "mx_domain":"mailhostbox.com",
    ///    "safe_to_send":"false",
    ///    "did_you_mean":"",
    ///    "success":"true",
    ///    "message":null
    ///  }
    /// </remarks>
    [Serializable]
    public class ValidateEmailResponse
    {
        public string result { get; set; }
        public string reason { get; set; }
        public string disposable { get; set; }
        public string accept_all { get; set; }
        public string role { get; set; }
        public string free { get; set; }
        public string email { get; set; }
        public string user { get; set; }
        public string domain { get; set; }
        public string mx_record { get; set; }
        public string mx_domain { get; set; }
        public string safe_to_send { get; set; }
        public string did_you_mean { get; set; }
        public string success { get; set; }
        public object message { get; set; }

        public ValidateEmailResponse()
        {

        }

        public override string ToString()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(this, options);
        }
    }
}

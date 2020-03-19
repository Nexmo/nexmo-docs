using Nancy;
using Newtonsoft.Json.Linq;
using System;

namespace NexmoVoiceASPNetCoreQuickStarts
{
    public class VoiceModule : NancyModule
    {
        public VoiceModule()
        {
            /// <summary>
            /// Depending on what you want to achieve (inbound call, handle DTMF input etc...)
            /// pick the suitable method to return the right NCCO for webhook/answer
            /// Check the Modules folder for all the samples
            /// </summary>
            Get["/webhook/answer"] = x => { var response = (Response)GetInboundNCCO();
                                            response.ContentType = "application/json";
                                            return response;
                                          };
            
            Post["/webhook/event"] = x => Request.Query["status"];
        }

        private string GetInboundNCCO()
        {
            dynamic TalkNCCO = new JObject();
            TalkNCCO.action = "talk";
            TalkNCCO.text = "Thank you for calling from " + string.Join(" ", this.Request.Query["from"].ToCharArray());
            TalkNCCO.voiceName = "Kimberly";

            JArray jarrayObj = new JArray();
            jarrayObj.Add(TalkNCCO);

            return jarrayObj.ToString();

        }
    }
}

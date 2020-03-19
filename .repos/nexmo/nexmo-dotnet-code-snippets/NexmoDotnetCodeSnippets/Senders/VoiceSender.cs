﻿using Newtonsoft.Json.Linq;
using Nexmo.Api.Request;
using Nexmo.Api.Voice;
using Nexmo.Api.Voice.Nccos;
using NexmoDotnetCodeSnippets.Authentication;

namespace NexmoDotnetCodeSnippets.Senders
{
    public class VoiceSender
    {
        public static Call.CallResponse MakeCall(string TO_NUMBER, string NEXMO_NUMBER)
        {
            var client = FullAuth.GetClient();

            var results = client.Call.Do(new Call.CallCommand
            {
                to = new[]
                {
                    new Call.Endpoint {
                        type = "phone",
                        number = TO_NUMBER
                    }
                },
                from = new Call.Endpoint
                {
                    type = "phone",
                    number = NEXMO_NUMBER
                },
                answer_url = new[]
                {
                    "https://developer.nexmo.com/ncco/tts.json"
                }
            });
            return results;
        }

        public static Call.CallResponse MakeCallWithNCCO(string TO_NUMBER, string NEXMO_NUMBER)
        {
            var client = FullAuth.GetClient();

            var talkAction = new TalkAction() { Text = "This is a text to speech call from Nexmo" };
            var ncco = new Ncco(talkAction);

            var results = client.Call.Do(new Call.CallCommand
            {
                to = new[]
                {
                    new Call.Endpoint {
                        type = "phone",
                        number = TO_NUMBER
                    }
                },
                from = new Call.Endpoint
                {
                    type = "phone",
                    number = NEXMO_NUMBER
                },

                NccoObj = ncco
            });
            return results;
        }

        public static Call.CallResponse GetCall(string UUID)
        {
            var client = FullAuth.GetClient();

            var result = client.Call.Get(UUID);

            return result;
        }

        public static Call.CallResponse MuteCall(string UUID)
        {
            var client = FullAuth.GetClient();

            var result = client.Call.Edit(UUID, new Call.CallEditCommand
            {
                Action = "mute"
            });

            return result;
        }

        public static Call.CallResponse UnmuteCall(string UUID)
        {
            var client = FullAuth.GetClient();

            var result = client.Call.Edit(UUID, new Call.CallEditCommand
            {
                Action = "unmute"
            });

            return result;
        }

        public static Call.CallResponse EarmuffCall(string UUID)
        {
            var client = FullAuth.GetClient();

            var result = client.Call.Edit(UUID, new Call.CallEditCommand
            {
                Action = "earmuff"
            });

            return result;
        }

        public static Call.CallResponse UnearmuffCall(string UUID)
        {
            var client = FullAuth.GetClient();

            var result = client.Call.Edit(UUID, new Call.CallEditCommand
            {
                Action = "unearmuff"
            });

            return result;
        }

        public static Call.CallResponse HangupCall(string UUID)
        {
            var client = FullAuth.GetClient();

            var result = client.Call.Edit(UUID, new Call.CallEditCommand
            {
                Action = "hangup"
            });

            return result;
        }

        public static Call.CallCommandResponse PlayTtsToCall(string UUID)
        {
            var client = FullAuth.GetClient();
            
            var TEXT = "This is a text to speech sample";
            var result = client.Call.BeginTalk(UUID, new Call.TalkCommand
            {
                text = TEXT,
                voice_name = "Kimberly"
            });

            return result;
        }

        public static Call.CallCommandResponse PlayAudioStreamToCall(string UUID)
        {
            var client = FullAuth.GetClient();

            var result = client.Call.BeginStream(UUID, new Call.StreamCommand
            {
                stream_url = new[] { "https://nexmo-community.github.io/ncco-examples/assets/voice_api_audio_streaming.mp3" }
            });

            return result;
        }

        public static Call.CallCommandResponse PlayDTMFToCall(string UUID)
        {
            var client = FullAuth.GetClient();

            var DIGITS = "8675309";

            var result = client.Call.SendDtmf(UUID, new Call.DtmfCommand()
            {
                digits = DIGITS
            });

            return result;
        }

        public static Call.CallResponse TransferCall(string UUID)
        {
            var client = FullAuth.GetClient();

            var result = client.Call.Edit(UUID, new Call.CallEditCommand
            {
                Action = "transfer",
                Destination = new Call.Destination
                {
                    Type = "ncco",
                    Url = new[] { "https://developer.nexmo.com/ncco/transfer.json" }
                }
            });

            return result;
        }

        public static PaginatedResponse<Call.CallList> GetAllCalls()
        {
            var client = FullAuth.GetClient();

            var response = client.Call.List();

            return response;
        }

        public static Call.CallGetRecordingResponse GetRecording(string recordingUrl)
        {
            var client = FullAuth.GetClient();

            var response = client.Call.GetRecording(recordingUrl);

            return response;
        }

        public static Call.CallResponse TransferCallWithInlineNCCO(string UUID)
        {
            var client = FullAuth.GetClient();
            var talkAction = new TalkAction() { Text = "This is a transfer action using an inline NCCO" };
            var ncco = new Ncco(talkAction);
            var response = client.Call.Edit(UUID,
                new Call.CallEditCommand()
                {
                    Action = "transfer",
                    Destination = new Call.Destination()
                    {
                        Type = "ncco",
                        Ncco = ncco
                    }
                });
            return response;
        }
    }
}

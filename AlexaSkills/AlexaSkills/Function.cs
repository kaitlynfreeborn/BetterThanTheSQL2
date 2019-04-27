using System.Net.Http;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AlexaWeather
{
    public class Function
    {
        public const string innvocation = "Weather";

        public Function()
        {
            _httpClient = new HttpClient();
        }
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        private static HttpClient httpClient;
        private HttpClient _httpClient;

        public SkillResponse FunctionHandler(SkillRequest input, ILambdaContext context)
        {
            var requestType = input.GetRequestType();
            if (requestType == typeof(IntentRequest))
            {
                return WeatherResponse(
                    $"Hello, I will check the weather. Give me one moment.", true);
            }
            else
            {
                return WeatherResponse(
                    $"I'm not sure what you're asking me. Please say something like Alexa, ask {innvocation} about the forecast in Norman, Oklahoma",
                    true);
            }

        }

        private SkillResponse WeatherResponse(string outputSpeech,
              bool endSession,
              string repromptText = "Just say, tell me a little more about this week's weather. To exit, say, thank you.")
        {
            var response = new ResponseBody
            {
                ShouldEndSession = endSession,
                OutputSpeech = new PlainTextOutputSpeech { Text = outputSpeech }

            };

            if (repromptText != null)
            {
                response.Reprompt = new Reprompt() { OutputSpeech = new PlainTextOutputSpeech() { Text = repromptText } };
            }

            var alexaResponse = new SkillResponse
            {
                Response = response,
                Version = "1.0"
            };

            return alexaResponse;
        }


    }
}

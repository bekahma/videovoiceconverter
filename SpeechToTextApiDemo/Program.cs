using Google.Cloud.Speech.V1;
using System;
using System.IO;

namespace SpeechToTextApiDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var speech = SpeechClient.Create();
            var config = new RecognitionConfig
            {
                Encoding = RecognitionConfig.Types.AudioEncoding.Flac,
                SampleRateHertz = 16000,
                LanguageCode = LanguageCodes.English.UnitedStates
            };
            
            var audio = RecognitionAudio.FromStorageUri("gs://cloud-samples-tests/speech/brooklyn.flac"); 

            var response = speech.Recognize(config, audio);

            foreach (var result in response.Results)
            {
                foreach (var alternative in result.Alternatives)
                {
                    using FileStream file = new FileStream("converted.txt", FileMode.OpenOrCreate, FileAccess.Write); 
                    using StreamWriter writer = new StreamWriter(file);

                    writer.WriteLine(alternative.Transcript);
                    // Console.WriteLine(alternative.Transcript);
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Helper
{
  /// <summary>
  /// Translater
  /// </summary>
  public class Translate
  {

    /// <summary>
    /// request api
    /// </summary>
    /// <param name="sourceLanguage"></param>
    /// <param name="targetLanguage"></param>
    /// <param name="query"></param>
    /// <returns></returns>
    private async Task<string> requestApi(string sourceLanguage, string targetLanguage, string query)
    {
      string result = "";
      var client = new HttpClient();
      var request = new HttpRequestMessage
      {
        Method = HttpMethod.Post,
        RequestUri = new Uri("https://google-translate1.p.rapidapi.com/language/translate/v2"),
        Headers =
  {
    { "X-RapidAPI-Key", "d6362057d6mshbddd69b6ae636abp19cf80jsn5b09a392fb51" },
    { "X-RapidAPI-Host", "google-translate1.p.rapidapi.com" },
  },
        Content = new FormUrlEncodedContent(new Dictionary<string, string>
  {
    { "q", query },
    { "target", targetLanguage },
    { "source", sourceLanguage},
  }),
      };
      using (var response = await client.SendAsync(request))
      {
        try
        {
          response.EnsureSuccessStatusCode();
          var body = await response.Content.ReadAsStringAsync();
          result = body;
        }
        catch
        {
          result = "<translate api key timeout>";
        }

      }

      return result;
    }

    /// <summary>
    /// Query
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public async Task<string> Query(string text)
    {
      return await requestApi("en", "tr", text);

    }
  }
}

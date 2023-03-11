using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
	public class QuoteGenerator
	{
		private HttpClient _client;

		public QuoteGenerator(HttpClient client)
		{
			_client = client;
		}

		public string Kanye()
		{
			var KanyeURL = "https://api.Kanye.rest";
			var KanyeResponse = _client.GetStringAsync(KanyeURL).Result;
			var KanyeQuote = JObject.Parse(KanyeResponse).GetValue("quote").ToString();
			return KanyeQuote;
		}

		public string RonSwanson()
		{
			var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
			var ronResponse = _client.GetStringAsync(ronURL).Result;
			var ronQuote = JArray.Parse(ronResponse);

			return ronQuote[0].ToString();
		}

	}
}


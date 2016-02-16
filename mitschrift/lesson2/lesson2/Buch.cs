using System;
using System.Net;

namespace lesson2
{
	enum Currency
	{
		EUR,
		USD,
		GBP,
		CHF,
		JPY
	}


	class Buch 
	{
		private string titel;
		private decimal preis;
		private Currency currency;
		//private Currency m_currency;

		public Buch(string derTitel, decimal derPreis, Currency currency)  // das ist ein Konstruktor. Er hat keinen Rückgabewert
		{
			titel = derTitel;
			SetPreis (derPreis); // Zuweisung des Wertes über Funktion.
			this.currency=currency; // This ist Referenz auf Objekt selbst und somit auf die private Variable!
			//m_currency=currency;
		}

		public string ISBN { get; private set; } // das ist ein get, set ohne weitere Prüfung.

		public string Titel // das ist eine Property
		{
			get
			{ 
				return titel;
			}
			set
			{ 
				if(string.IsNullOrEmpty(value) || value.Length <3)  //value steht als Platzhalter für Wert und darf nur in switch-statements wie diesem verwendet werden
					throw new Exception("Titel muss mindestens 3 Zeichen haben");
			}

		}

		public decimal GetPreis(Currency c)
		{
			if (c== this.currency) return preis;

			var key = string.Format("{0}{1}", c, this.currency); // e.g. EURUSD means "How much is 1 EUR in USD?".
			// create the request URL, ...
			var url = string.Format(@"http://download.finance.yahoo.com/d/quotes.csv?s={0}=X&f=sl1d1t1c1ohgv&e=.csv", key);
			// download the response as string
			var data = new WebClient().DownloadString(url);
			// split the string at ','
			var parts = data.Split(',');
			// convert the exchange rate part to a decimal 
			var rate = decimal.Parse(parts[1], CultureInfo.InvariantCulture);

			// and finally perform the currency conversion
			return preis * rate;
		}
		public void SetPreis(decimal neuerPreis)
		{
			if (neuerPreis < 0)
				throw new Exception ("Preis muss positiv sein!");
			preis = neuerPreis;
		}
	}
}


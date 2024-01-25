using System;

class Entry
{
    public DateTime Date { get; }
    public string Prompt { get; }
    public string Response { get; }
    public string AdditionalInfo { get; }

    public Entry(string prompt, string response, DateTime date, string additionalInfo)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
        AdditionalInfo = additionalInfo;
    }

    public Entry(DateTime date, string prompt, string response, string additionalInfo)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
        AdditionalInfo = additionalInfo;
    }
}

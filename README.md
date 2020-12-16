# EmailCampaignsAPI SDK
.NET Standard SDK to send email with the CM EmailCampaigns API

## API Documentation
https://docs.cmtelecom.com/en/api/email-campaigns

# Usage

## Instantiate a client

```cs
HttpClient httpClient = new HttpClient();
EmailClient emailClient = new EmailClient(httpClient, myApiKey, baseUrl);
```

`httpClient` is requested as a parameter, such that you can use a single instance throughout your application, as is highly recommended.

`myApiKey` is your unique api key (or product token) which authorizes you on the CM platform. Always keep this key secret!

`baseUrl` is optional and will be defaulted to https://api.cmtelecom.com when not filled in. Else the requests will be send to the filled in domain.

## Send an email

You can send a mail by calling the `SendMailAsync` method and providing your accountID (found in the API credentials under settings in the Email Campaigns app), the Mail object and a cancellation token (optional).

```cs
Mail mail = new Mail()
{
  FromAddressID = fromAddressID,
  FromName = fromName, //optional
  ReplyToAddressID = replyToAddressID, // optional
  ReplyToAddress = replyToAddress, // optional (Overwritten when ReplyToAddressID defined)
  ReplyToName = replyToName, // optional (Requires ReplyToAddressID or ReplyToAddress to be filled)
  ToAddress = toAddress,
  ToName = toName, // optional
  Ccs = new MailAddress[] // optional
  { 
    new MailAddress() { EmailAddress = ccToAddress }
  },
  Bccs = new MailAddress[] // optional
  {
    new MailAddress() { EmailAddress = bccToAddress }
  },
  Subject = "SDK SingleMail test",
  HtmlBody = "<html><body>What a beautifull email</body></html>",
  TextBody = "What a beautifull email",
  Attachments = new Attachment[]
  {
    new Attachment 
      {
        FileName = attachmentFileName,
        Content = attachmentContent, // base64 encoded content of the attachment
        ContentID = attachmentContentID // The ContentID can be specified for images, to reference it in your image tag in your HTML. You can use "cid:yourcontentid" in the src tag of the image to display the image inline.
      }
  }, // optional
  CustomerReference = yourOwnReference //optional
};
  
Mail sendMail = await emailClient.SendMailAsync(accountID, mail).ConfigureAwait(false);
```

## Send a triggered campaign mail

You can send a triggered mail by calling the `SendCampaignMailAsync` method and providing your accountID (found in the API credentials under settings in the Email Campaigns app), the triggeredCampaignID over which you want to send the mail, the CampaignMail object (with a ToAddress and custom values) and a cancellation token (optional).

```cs
CampaignMail campaignMail = new CampaignMail()
{
  ToAddress = "recipientsEmailAddress",
  ToName = toName, //optional
  CustomValues = new CustomValue[]
  {
    new CustomValue() { Field = "Firstname", Value = "recipientsFirstname" }
  }
};

CampaignMail sendCampaignMail = await emailClient.SendCampaignMailAsync(accountID, triggeredCampaignID, campaignMail).ConfigureAwait(false);
```

## Other requests
The send mail requests are explained in a bit more detail above because those are the most used methods, but no worries, all other implemented requests are working in a similar way and should be easy to use. 

# NumberValidAPI

<h3>Functionality of this API is pertty simple - send your/friends phone number as request and get json answer with next properties:</h3>
<ol>
  <li>number valid</li>
  <li>Country code</li>
  <li>Country name</li>
  <li>Short Country name</li>
  <li>Mobile operator</li>
  <li>Mobile operator code</li>
</ol>
<hr />

<h5>To use api send .../api/number/validate?number=phone_here</h5>
<h5>To check supported countries .../api/number/countries</h5>

Examples of JSON answer:

request: .../api/number/validate?number=79211234564
```json
  {
    "valid":true,
    "number":"79211234564",
    "e164format":"+79211234564",
    "internationalFormat":"+7 921-123-4564",
    "nationalFormat":"(921) 123-4564",
    "countryCode":7,"country":"Russia",
    "countryShort":"RUS","operatorName":"Megafon",
    "operCode":"921"
  }

```
request: .../api/number/validate?number=22813121234564
We can see that this number is strange, this is what we will recieve:
```json
{
  "valid":false,
  "message":"Check your number, it may have some errors, and be sure that you wrote it without + at the start. And check supported    countries(use api/number/countries path), maybe we don't support your country."
}
```

<h3>At all this is main endpoints at this API(feel ur self as fbi person=) )</h3>
<span>:fireworks::fireworks::fireworks:</span>
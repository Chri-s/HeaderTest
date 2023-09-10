# HeaderTest
This is a simple website to check request headers (for testing reverse proxy configurations).

This can be useful to test a reverse proxy configuration, for example if the reverse proxy sets headers or strips unwanted headers.
For example if the reverse proxy sets the `X-Forwarded-For` header. By default Apache appends its IP address if the client already sends a `X-Forwarded-For` header.

This website has 2 endpoints:

<code>/</code> shows an HTML page with the headers like this:

<table border="1">
  <tr>
    <th>Name</th>
    <th>Value</th>
  </tr>
  <tr>
    <td rowspan="1">Accept</td>
    <td>text/html,application/xhtml&#x2B;xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7</td>
  </tr>
  <tr>
    <td rowspan="1">Accept-Encoding</td>
    <td>gzip, deflate, br</td>
  </tr>
</table>

<code>/api/headers/</code> returns a json string with the headers like this:

```json
{
    "Accept": [
        "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7"
    ],
    "Accept-Encoding": [
        "gzip, deflate, br"
    ]
}
```

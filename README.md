# Function App Http Response Test


[![Deploy To Azure](https://raw.githubusercontent.com/Azure/azure-quickstart-templates/master/1-CONTRIBUTION-GUIDE/images/deploytoazure.svg?sanitize=true)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fgabesmsft%2FFunctionAppHttpResponseTest%2Fmaster%2Fdeploy%2Fazuredeploy.json)

This sample Azure Resource Manager template deploys a Function App, Storage account, App Insights instance, and Log Analytics workspace.

The Function App contains the following HTTP Triggers:

- **FastHttpFunctionAnonymous**: Does not require auth. Should return an HTTP 200 response quickly.
- **FastHttpFunctionWithFunctionKeyAuth**: Requires a Function key. If a valid key is provided in the request, should return an HTTP 200 response quickly. Otherwise should fail with an authentication error.
- **FastHttpFunctionWithMasterKeyAuth**: Requires the Function App master key. If a valid key is provided in the request, should return an HTTP 200 response quickly. Otherwise should fail with an authentication error.
- **FastHttpFunctionWithSystemKeyAuth**: Requires the Function App system key. If a valid key is provided in the request, should return an HTTP 200 response quickly. Otherwise should fail with an authentication error.
- **FastHttpFunctionWithUserTokenAuth**: Requires a user token (i.e. if you configure Authentication on the Function App). If a valid token is provided in the request, should return an HTTP 200 response quickly. Otherwise should fail with an authentication error.
- **Http400Function**: Should return an HTTP 400 response. Does not require auth (the auth is set to anonymous on the function).
- **Http500Function**: Should return an HTTP 500 response. Does not require auth (the auth is set to anonymous on the function).
- **Slow10SecondHttpFunction**: Should return an HTTP 200 response after ~10 seconds. Does not require auth (the auth is set to anonymous on the function).
- **Slow30SecondHttpFunction**: Should return an HTTP 200 response after ~10 seconds. Does not require auth (the auth is set to anonymous on the function).

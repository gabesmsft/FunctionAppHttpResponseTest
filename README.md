# Function App Http Response Test


[![Deploy To Azure](https://raw.githubusercontent.com/Azure/azure-quickstart-templates/master/1-CONTRIBUTION-GUIDE/images/deploytoazure.svg?sanitize=true)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fgabesmsft%2FFunctionAppHttpResponseTest%2Fmaster%2Fdeploy%2Fazuredeploy.json)

This sample Azure Resource Manager template deploys a Function App, Storage account, App Insights instance, and Log Analytics workspace.

The Function App contains the following HTTP Triggers:

- /api/FastHttpFunction
- /api/Http400Function
- /api/Http500Function
- /api/Slow10SecondHttpFunction
- /api/Slow30SecondHttpFunction


# Selling Patner API Models

## This is the repo maintained by IL to generate client code using AutoRest, to know more about AutoRest, check [Azure AutoRest](https://github.com/Azure/autorest).

 # Prerequisites 
 
 * AutoRest. Installing AutoRest on Windows, MacOS or Linux involves two steps:

1. __Install [Node.js](https://nodejs.org/en/)__ (12.19.x LTS preferred. May not function with Node < 10.x.)
> if you want an easy way to install and update Node, I recommend [NVS - Node Version Switcher](./installing-via-nvs.md) or [NVM - Node Version Manager](./installing-via-nvm.md)


2. __Install AutoRest__ using `npm`

  ``` powershell
  # Depending on your configuration you may need to be elevated or root to run this. (on OSX/Linux use 'sudo' )
  The latest version is V3, but it doesn't accept HttpClient as a parameter in its constructors, so we have to fall back to V2, 

  npm install -g autorest@previous

  # run using command 'autorest' to check if installation worked
  autorest --help
 

 # Steps to generate client code
 
 Take Orders API as example, orders.ps1:

\```
Import-Module .\generator.psm1
Import-Module .\replace.psm1
Import-Module .\factory.psm1

$templatFile = '.\models\orders-api-model\ordersV0.json'
$outputFolder = '.\clients\IL\Orders'
$namespace = 'IL.Library.Amazon.SPAPI.Orders'
$clientname = 'OrdersClient'

generate $templatFile $outputFolder $namespace $clientname

addcode $outputFolder'\'$clientname'.cs' 'HttpClient.SendAsync'  '            PrepareRequest(_httpRequest);'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
 
\```

generate.psm1 uses AutoRest command to generate the Models and API interface.
addcode.psm1 embeds one line code 'PrepareRequest(_httpRequest)' before the line of 'HttpClient.SendAsync', so we can chime in and add the required auth headers.
factory.psm1 generates another source code file that implements PrepareRequest and a static instance create function.


## Security

See [CONTRIBUTING](CONTRIBUTING.md#security-issue-notifications) for more information.

## License

This project is licensed under the Apache-2.0 License.

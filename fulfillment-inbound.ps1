Import-Module .\generator.psm1
Import-Module .\replace.psm1
Import-Module .\factory.psm1

$templatFile = '.\models\fulfillment-inbound-api-model\fulfillmentInboundV0.json'
$outputFolder = '.\clients\IL\FulfillmentInbound'
$namespace = 'IL.Library.Amazon.SPAPI.FulfillmentInbound'
$clientname = 'FulfillmentInboundClient'

generate $templatFile $outputFolder $namespace $clientname

addcode $outputFolder'\'$clientname'.cs' 'HttpClient.SendAsync'  '            PrepareRequest(_httpRequest);'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
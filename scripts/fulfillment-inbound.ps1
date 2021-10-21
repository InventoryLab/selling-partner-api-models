Import-Module .\modules\generator.psm1
Import-Module .\modules\prepareresponse.psm1
Import-Module .\modules\preparerequest.psm1
Import-Module .\modules\factory.psm1

$templatFile = '..\models\fulfillment-inbound-api-model\fulfillmentInboundV0.json'
$outputFolder = '..\clients\IL\FulfillmentInbound'
$namespace = 'IL.Library.Amazon.SPAPI.FulfillmentInbound'
$clientname = 'FulfillmentInboundClient'

Remove-Item -Path $outputFolder -Recurse 

generate $templatFile $outputFolder $namespace $clientname

addPrepareResponse $outputFolder'\'$clientname'.cs'
addPrepareRequest $outputFolder'\'$clientname'.cs'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
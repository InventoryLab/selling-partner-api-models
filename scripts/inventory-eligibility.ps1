Import-Module .\modules\generator.psm1
Import-Module .\modules\prepareresponse.psm1
Import-Module .\modules\preparerequest.psm1
Import-Module .\modules\factory.psm1

$templatFile = '..\models\fba-inbound-eligibility-api-model\fbaInbound.json'
$outputFolder = '..\clients\IL\FBAInboundEligibility'
$namespace = 'IL.Library.Amazon.SPAPI.FBAInboundEligibility'
$clientname = 'FBAInboundEligibilityClient'

Remove-Item -Path $outputFolder -Recurse 

generate $templatFile $outputFolder $namespace $clientname


addPrepareResponse $outputFolder'\'$clientname'.cs'
addPrepareRequest $outputFolder'\'$clientname'.cs'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
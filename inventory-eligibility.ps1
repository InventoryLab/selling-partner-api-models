Import-Module .\generator.psm1
Import-Module .\replace.psm1
Import-Module .\factory.psm1

$templatFile = '.\models\fba-inbound-eligibility-api-model\fbaInbound.json'
$outputFolder = '.\clients\IL\FBAInboundEligibility'
$namespace = 'IL.Library.Amazon.SPAPI.FBAInboundEligibility'
$clientname = 'FBAInboundEligibilityClient'

generate $templatFile $outputFolder $namespace $clientname

addcode $outputFolder'\'$clientname'.cs' 'HttpClient.SendAsync'  '            PrepareRequest(_httpRequest);'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
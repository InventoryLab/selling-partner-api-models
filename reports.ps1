Import-Module .\generator.psm1
Import-Module .\replace.psm1
Import-Module .\factory.psm1

$templatFile = '.\models\reports-api-model\reports_2020-09-04.json'
$outputFolder = '.\clients\IL\Reports'
$namespace = 'IL.Library.Amazon.SPAPI.Reports'
$clientname = 'ReportsClient'

generate $templatFile $outputFolder $namespace $clientname

addcode $outputFolder'\'$clientname'.cs' 'HttpClient.SendAsync'  '            PrepareRequest(_httpRequest);'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
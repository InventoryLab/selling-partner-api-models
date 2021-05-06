Import-Module .\generator.psm1
Import-Module .\replace.psm1
Import-Module .\factory.psm1

$templatFile = '.\models\feeds-api-model\feeds_2021-06-30.json'
$outputFolder = '.\clients\IL\Feeds'
$namespace = 'IL.Library.Amazon.SPAPI.Feeds'
$clientname = 'FeedsClient'

generate $templatFile $outputFolder $namespace $clientname

addcode $outputFolder'\'$clientname'.cs' 'HttpClient.SendAsync'  '            PrepareRequest(_httpRequest);'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
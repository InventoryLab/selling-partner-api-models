Import-Module .\generator.psm1
Import-Module .\replace.psm1
Import-Module .\factory.psm1

$templatFile = '.\models\tokens-api-model\tokens_2021-03-01.json'
$outputFolder = '.\clients\IL\Tokens'
$namespace = 'IL.Library.Amazon.SPAPI.Tokens'
$clientname = 'TokensClient'

generate $templatFile $outputFolder $namespace $clientname

addcode $outputFolder'\'$clientname'.cs' 'HttpClient.SendAsync'  '            PrepareRequest(_httpRequest);'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
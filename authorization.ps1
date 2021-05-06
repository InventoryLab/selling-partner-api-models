Import-Module .\generator.psm1
Import-Module .\replace.psm1
Import-Module .\factory.psm1

$templatFile = '.\models\authorization-api-model\authorization.json'
$outputFolder = '.\clients\IL\Authorization'
$namespace = 'IL.Library.Amazon.SPAPI.Authorization'
$clientname = 'AuthorizationClient'

generate $templatFile $outputFolder $namespace $clientname

addcode $outputFolder'\'$clientname'.cs' 'HttpClient.SendAsync'  '            PrepareRequest(_httpRequest);'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
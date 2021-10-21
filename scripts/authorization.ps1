Import-Module .\modules\generator.psm1
Import-Module .\modules\prepareresponse.psm1
Import-Module .\modules\preparerequest.psm1
Import-Module .\modules\factory.psm1

$templatFile = '..\models\authorization-api-model\authorization.json'
$outputFolder = '..\clients\IL\Authorization'
$namespace = 'IL.Library.Amazon.SPAPI.Authorization'
$clientname = 'AuthorizationClient'

Remove-Item -Path $outputFolder -Recurse 

generate $templatFile $outputFolder $namespace $clientname

addPrepareResponse $outputFolder'\'$clientname'.cs'
addPrepareRequest $outputFolder'\'$clientname'.cs'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
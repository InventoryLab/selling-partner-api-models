Import-Module .\modules\generator.psm1
Import-Module .\modules\prepareresponse.psm1
Import-Module .\modules\preparerequest.psm1
Import-Module .\modules\factory.psm1

$templatFile = '..\models\uploads-api-model\uploads_2020-11-01.json'
$outputFolder = '..\clients\IL\Uploads'
$namespace = 'IL.Library.Amazon.SPAPI.Uploads'
$clientname = 'UploadsClient'

Remove-Item -Path $outputFolder -Recurse 

generate $templatFile $outputFolder $namespace $clientname


addPrepareResponse $outputFolder'\'$clientname'.cs'
addPrepareRequest $outputFolder'\'$clientname'.cs'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
Import-Module .\generator.psm1
Import-Module .\replace.psm1
Import-Module .\factory.psm1

$templatFile = '.\models\uploads-api-model\uploads_2020-11-01.json'
$outputFolder = '.\clients\IL\Uploads'
$namespace = 'IL.Library.Amazon.SPAPI.Uploads'
$clientname = 'UploadsClient'

generate $templatFile $outputFolder $namespace $clientname

addcode $outputFolder'\'$clientname'.cs' 'HttpClient.SendAsync'  '            PrepareRequest(_httpRequest);'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
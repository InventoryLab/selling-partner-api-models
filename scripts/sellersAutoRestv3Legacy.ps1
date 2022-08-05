Import-Module .\modules\generator.psm1
Import-Module .\modules\prepareresponse.psm1
Import-Module .\modules\preparerequest.psm1
Import-Module .\modules\factory.psm1

$templatFile = '..\models\sellers-api-model\sellers.json'
$outputFolder = '..\clients\IL\Sellers'
$namespace = 'IL.Library.Amazon.SPAPI.Sellers'
$clientname = 'SellersClient'

#Remove-Item -Path $outputFolder -Recurse 

#generate $templatFile $outputFolder $namespace $clientname

autorest --legacy --input-file=$templatFile --csharp --output-folder=$outputFolder --namespace=$namespace --override-client-name=$clientName 

addPrepareResponse $outputFolder'\'$clientname'.cs'
addPrepareRequest $outputFolder'\'$clientname'.cs'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
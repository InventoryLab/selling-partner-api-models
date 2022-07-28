Import-Module .\modules\generator.psm1
Import-Module .\modules\prepareresponse.psm1
Import-Module .\modules\preparerequest.psm1
Import-Module .\modules\factory.psm1

$templatFile = '..\models\catalog-items-api-model\catalogItems_2022-04-01.json'
$outputFolder = '..\clients\IL\CatalogItems'
$namespace = 'IL.Library.Amazon.SPAPI.CatalogItems'
$clientname = 'CatalogItemsClient'

Remove-Item -Path $outputFolder -Recurse 

generate $templatFile $outputFolder $namespace $clientname

addPrepareResponse $outputFolder'\'$clientname'.cs'
addPrepareRequest $outputFolder'\'$clientname'.cs'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
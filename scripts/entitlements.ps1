﻿Import-Module .\modules\generator.psm1
Import-Module .\modules\prepareresponse.psm1
Import-Module .\modules\preparerequest.psm1
Import-Module .\modules\factory.psm1

$templatFile = '..\models\entitlements-api-model\appManagement-2022-07-21.json'
$outputFolder = '..\clients\IL\Entitlements'
$namespace = 'IL.Library.Amazon.SPAPI.Entitlements'
$clientname = 'EntitlementsClient'

Remove-Item -Path $outputFolder -Recurse 

generate $templatFile $outputFolder $namespace $clientname

addPrepareResponse $outputFolder'\'$clientname'.cs'
addPrepareRequest $outputFolder'\'$clientname'.cs'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname
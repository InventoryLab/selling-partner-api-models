

function createfactory($templateFile,$dest,$newfilename,$namespace, $classname)
{
    Copy-Item $templateFile -Destination $dest
    Rename-Item -Path $dest\$templateFile -NewName $newfilename
    (Get-Content -path $dest\$newfilename -Raw) -replace '{#namespace}',$namespace | Set-Content -Path $dest\$newfilename
    (Get-Content -path $dest\$newfilename -Raw) -replace '{#className}',$classname | Set-Content -Path $dest\$newfilename
}

Export-ModuleMember -Function createfactory
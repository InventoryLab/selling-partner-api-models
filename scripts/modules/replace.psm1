
function addcode($fileName, $pattern, $newstring, $after)
{
	
	[System.Collections.ArrayList]$file = Get-Content $fileName
	$insert = @()

	for ($i=0; $i -lt $file.count; $i++) {
  	    if ($file[$i] -match $pattern) {
    	    $insert += $i+$after #Record the position of the line before this one
            write-host "line number:" $i
  		}
	}

	#Now loop the recorded array positions and insert the new text
	$insert | Sort-Object -Descending | ForEach-Object { 
        write-host $_ 
        $content = $file | Select -Index ($_ - 1) 
        write-host $content.Substring($content.IndexOf('<'), $content.IndexOf('>') - $content.IndexOf('<') + 1)
        $file.insert($_,$newstring) 
        }

	Set-Content $FileName $file
}

Export-ModuleMember -Function addcode
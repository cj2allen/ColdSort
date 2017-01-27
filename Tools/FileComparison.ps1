Get-ChildItem -Path .\ -Recurse -File -Name| ForEach-Object {
    [System.IO.Path]::GetFileName($_)
} | Sort-Object | Out-File music.txt
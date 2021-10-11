param(
[Parameter(Mandatory)]
[string] $name,
[string] $baseUri = "http://localhost:60781"
)

Invoke-RestMethod "$baseUri/api/workflow3s" -Method post `
        -Headers @{"X-CCC-FP-Email" = "john@mailinator.com"; "X-CCC-FP-Roles" = "admin,adjuster" } `
        -Body (ConvertTo-Json @{name = $name}) `
        -ContentType "application/json"
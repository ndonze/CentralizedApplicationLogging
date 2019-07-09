# Setup
1. Ensure the [Terraform](https://www.terraform.io/) binary is available on your path
1. [Authenticate with Azure](https://www.terraform.io/docs/providers/azurerm/auth/azure_cli.html) to allow Terraform to provision resources
1. `cd .\Terraform`
1. `terraform init`
1. `terraform plan`
1. `terraform apply` to create Azure resources
1. Launch the Service1 and Service2 projects and navigate between the Home and Privacy pages to generate log entries
1. Inspect log entries in Application Insights under Search and Log (Analytics). Optionally [union data across both Application Insights instances](https://docs.microsoft.com/en-us/azure/azure-monitor/log-query/unify-app-resource-data) e.g.
```
union app('service1-ai').traces, app('service2-ai').traces
| where message contains 'home page'
```
1. `terraform destroy` to remove Azure resources
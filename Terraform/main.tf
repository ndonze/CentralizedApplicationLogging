resource "azurerm_resource_group" "rg" {
    name = "centralizedlogging-rg"
    location = "East US"
}

resource "azurerm_application_insights" "service1-ai" {
    name = "service1-ai"
    location = "${azurerm_resource_group.rg.location}"
    resource_group_name = "${azurerm_resource_group.rg.name}"
    application_type = "Web"

    provisioner "local-exec" {
        command = "cd ..\\CentralizedApplicationLogging.Service1 && dotnet user-secrets set ApplicationInsights:InstrumentationKey ${azurerm_application_insights.service1-ai.instrumentation_key}"
    }
}

/*
resource "azurerm_application_insights" "service2-ai" {
    name = "service2-ai"
    location = "${azurerm_resource_group.rg.location}"
    resource_group_name = "${azurerm_resource_group.rg.name}"
    application_type = "Web"

    provisioner "local-exec" {
        command = "cd ..\\CentralizedApplicationLogging.Service2 && dotnet user-secrets set ApplicationInsights:InstrumentationKey ${azurerm_application_insights.service2-ai.instrumentation_key}"
    }
}
*/
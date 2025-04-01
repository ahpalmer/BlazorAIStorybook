// JavaScript functions for Blazor interaction

// Function to get input value by element ID
function getInputValue(elementId) {
    console.log("Getting value for element:", elementId);
    const element = document.getElementById(elementId);
    if (!element) {
        console.error("Element not found:", elementId);
        return "";
    }
    console.log("Element value:", element.value);
    return element.value || "";
} 
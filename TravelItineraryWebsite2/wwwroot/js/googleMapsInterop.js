export function initializePlaceAutocomplete(element, dotNetReference) {
    async function initMap() {
        //@ts-ignore
        await google.maps.importLibrary("places");

        // Create autocomplete element
        //@ts-ignore
        const autocomplete = new google.maps.places.PlaceAutocompleteElement();
        element.appendChild(autocomplete);

        // Listen for place selection
        autocomplete.addEventListener('gmp-placeselect', async ({ place }) => {
            await place.fetchFields({
                fields: ["displayName", "formattedAddress", "location"]
            });

            // Send data to Blazor
            dotNetReference.invokeMethodAsync('HandlePlaceSelected', {
                displayName: place.displayName,
                address: place.formattedAddress,
                location: {
                    lat: place.location.lat(),
                    lng: place.location.lng()
                }
            });
        });
    }

    initMap();
}
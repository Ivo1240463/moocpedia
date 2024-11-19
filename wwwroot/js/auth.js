let auth0Client = null;

async function initAuth0(domain, client_id) {
    auth0Client = await createAuth0Client({
        domain: domain,
        client_id: client_id,
        cacheLocation: "localstorage", // Use local storage to persist session
        useRefreshTokens: true
    });
}

// Check if the user is authenticated
async function checkAuth0Auth() {
    if (!auth0Client) await initAuth0();
    return await auth0Client.isAuthenticated();
}

// Get the user profile
async function getAuth0User() {
    if (!auth0Client) await initAuth0();
    return await auth0Client.getUser();
}

// Login the user
async function loginWithRedirect() {
    if (!auth0Client) await initAuth0();
    await auth0Client.loginWithRedirect({
        redirect_uri: window.location.origin
    });
}

// Logout the user
async function logout() {
    if (!auth0Client) await initAuth0();
    auth0Client.logout({
        returnTo: window.location.origin
    });
}
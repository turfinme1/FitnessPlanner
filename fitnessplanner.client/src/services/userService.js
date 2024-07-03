export const updateProfile = async (data) => {
  const response = await fetch("user/update-data", {
    method: "PUT",
    headers: {
      "Content-Type": "application/json",
      Authorization:
        "Bearer " +
        JSON.parse(sessionStorage.getItem("authData")).state.accessToken,
    },
    body: JSON.stringify(data),
  });

  if (response.status === 201 || response.status === 204) {
    console.log(response);
    // return data;
    return true;
  }

  return false;
};

export const getUserFormData = async () => {
  const response = await fetch("user/form-data", {
    method: "GET",
    headers: {
      "Content-Type": "application/json",
      Authorization:
        "Bearer " +
        JSON.parse(sessionStorage.getItem("authData")).state.accessToken,
    },
  });

  if (response.status === 200) {
    console.log(response);
    const data = await response.json();
    console.log(data);
    return data;
  }

  return null;
}

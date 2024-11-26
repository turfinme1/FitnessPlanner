export const updateProfile = async (data) => {
  const response = await fetch("api/user/update-data", {
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
  const response = await fetch("api/user/form-data", {
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

export const getUserWorkoutPlans = async () => {
  const response = await fetch("api/user/workout-plan", {
    headers: {
      Authorization: "Bearer " + JSON.parse(sessionStorage.getItem("authData")).state.accessToken,
    },
  });
  const data = await response.json();
  return data.result;
};

export const addWorkoutToUserProfile = async (workoutPlanId) => {
  const response = await fetch(`api/user/workout-plan/${workoutPlanId}`, {
    method: 'POST',
    headers: {
      Authorization: 'Bearer ' + JSON.parse(sessionStorage.getItem('authData'))?.state.accessToken,
    },
  });
  const data = await response.json();
  return data.success;
};

export const removeWorkoutPlan = async (workoutPlanId) => {
  const response = await fetch(`api/user/workout-plan/${workoutPlanId}`, {
    method: "DELETE",
    headers: {
      Authorization: "Bearer " + JSON.parse(sessionStorage.getItem("authData")).state.accessToken,
    },
  });
  const data = await response.json();
  return data.success;
};

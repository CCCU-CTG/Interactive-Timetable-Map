//Take input username or password from user in your registration form.

//Create Hash and Salt for input password with below method.

public class HashSalt
{
    public string Hash { get; set; }
    public string Salt { get; set; }
}

public static HashSalt GenerateSaltedHash(int size, string password)
{
    var saltBytes = new byte[size];
    var provider = new RNGCryptoServiceProvider();
    provider.GetNonZeroBytes(saltBytes);
    var salt = Convert.ToBase64String(saltBytes);

    var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
    var hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

    HashSalt hashSalt = new HashSalt { Hash = hashPassword, Salt = salt };
    return hashSalt;
}


//Then stored this Hash and Salt with user record in database.

public void Submit1_click(object sender, EventArgs r)
{
    //Krink code here

    HashSalt hashSalt = GenerateSaltedHash(64, password1.Text);

    //Your code here

    cmd.Parameters.AddWithValue("@hash", hashSalt.Hash);
    cmd.Parameters.AddWithValue("@salt", hashSalt.Salt);

    //Krink code here
}

//User Login

//Take input username or password from user in your login form.

//In Login_click get user by username from database.

//Pass stored Hash and Salt to below function.

public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
{
    var saltBytes = Convert.FromBase64String(storedSalt);
    var rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 10000);
    return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == storedHash;
}

//Then login your user by verifying his/her password.

public void Login_click(object sender, EventArgs r)
{
    //Krink code here

    User user = GetUserByUsername(txtUsername.Text);

    bool isPasswordMatched = VerifyPassword(txtpassword.Text, user.Hash, user.Salt);

    if (isPasswordMatched)
    {
        //Login Successfull
    }
    else
    {
        //Login Failed
    }

    //Krink code here
}


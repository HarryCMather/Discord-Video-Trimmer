namespace Discord.Video.Trimmer.Views.Components;

/// <summary>
/// A ContentView wrapper, making it easier to conditionally render content within XAML Views.
/// This aims to reduce boilerplate XAML code and only render the necessary components.
/// Whilst the IsVisible property does exist, it will still render the view regardless of whether it's displayed.
/// </summary>
public sealed class ConditionalContentView : ContentView
{
    // ReSharper disable once MemberCanBePrivate.Global
    // Justification: ReSharper doesn't have sufficient context to realise this is used.  If set to private, the project won't build.
    /// <summary>
    /// Backing property for handling Condition accessor state changes.
    /// </summary>
    public static readonly BindableProperty ConditionProperty = BindableProperty.Create(propertyName: nameof(Condition),
                                                                                        returnType: typeof(bool),
                                                                                        declaringType: typeof(ConditionalContentView),
                                                                                        defaultValue: false, 
                                                                                        propertyChanged: OnConditionalPropertyChanged);
    
    /// <summary>
    /// Backing property for handling True accessor state changes.
    /// </summary>
    public static readonly BindableProperty TrueProperty = BindableProperty.Create(propertyName: nameof(True),
                                                                                   returnType: typeof(View),
                                                                                   declaringType: typeof(ConditionalContentView),
                                                                                   defaultValue: null, 
                                                                                   propertyChanged: OnConditionalPropertyChanged);
    
    /// <summary>
    /// Backing property for handling False accessor state changes.
    /// </summary>
    public static readonly BindableProperty FalseProperty = BindableProperty.Create(propertyName: nameof(False),
                                                                                    returnType: typeof(View),
                                                                                    declaringType: typeof(ConditionalContentView),
                                                                                    defaultValue: null, 
                                                                                    propertyChanged: OnConditionalPropertyChanged);
    
    /// <summary>
    /// Accessor for Condition.
    /// This is used to determine whether to display the True or False View.
    /// </summary>
    public bool Condition
    {
        get => (bool)GetValue(ConditionProperty);
        set => SetValue(ConditionProperty, value);
    }

    /// <summary>
    /// Accessor for the True View.
    /// This is conditionally rendered if 'Condition' is true.
    /// </summary>
    public View True
    {
        get => (View)GetValue(TrueProperty);
        set => SetValue(TrueProperty, value);
    }

    /// <summary>
    /// Accessor for the False View.
    /// This is conditionally rendered if 'Condition' is false.
    /// </summary>
    public View False
    {
        get => (View)GetValue(FalseProperty);
        set => SetValue(FalseProperty, value);
    }
    
    private static void OnConditionalPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is ConditionalContentView view)
        {
            view.Content = view.Condition switch
            {
                true => view.True,
                false => view.False
            };
        }
    }
}

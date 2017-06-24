package pers.oliver.hex;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.Application;
import android.content.ClipboardManager;
import android.content.DialogInterface;
import android.content.SharedPreferences;
import android.content.res.Resources;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.graphics.Color;
import android.os.AsyncTask;
import android.provider.Telephony;
import android.support.v4.view.MotionEventCompat;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.support.v7.app.ActionBarDrawerToggle;
import android.support.v7.internal.widget.ContentFrameLayout;
import android.text.Editable;
import android.text.Spannable;
import android.text.TextWatcher;
import android.text.method.MovementMethod;
import android.text.method.ScrollingMovementMethod;
import android.util.Log;
import android.view.GestureDetector;
import android.view.KeyEvent;
import android.view.Menu;
import android.view.MenuItem;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.view.animation.AlphaAnimation;
import android.view.animation.Animation;
import android.view.animation.ScaleAnimation;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.ListView;
import android.widget.SeekBar;
import android.widget.SimpleAdapter;
import android.widget.TableLayout;
import android.widget.TextView;
import android.widget.Toast;

import org.w3c.dom.Text;

import java.io.FileWriter;
import java.io.IOException;
import java.math.BigInteger;
import java.text.ParseException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Objects;
import java.util.Random;


public class MainActivity extends  Activity  {

    private Button[] button=new Button[18];
    private TextView inputText,binText,decText,octText,hexText,bfConvertText,afConvertText;
    private ContentFrameLayout cf;
    private ActionBarDrawerToggle mDrawerToggle;
    private DrawerLayout mDrawerLayout;
    private ListView leftList,rightList;
    private SimpleAdapter leftListAdapter,rightListAdapter;
    private ArrayList<HashMap<String,Object>> leftListItem,rightListItem;
    private SeekBar seekBar;
    private TableLayout backLayout;
    private int valRed=0,valBlue=0,valGreen=0;
    private int setRadix = 10;
    private SQLiteDatabase sqLiteDatabase;
    private void addItem(int id,String title,ArrayList<HashMap<String,Object>> al){

        HashMap<String,Object> map=new HashMap<String,Object>();
        map.put("image", id);
        map.put("title",title);
        al.add(map);
    }



    private void startConver(){
        if(inputText.getText().length()<1)
            return;
        try {

            binText.setText(new BigInteger(inputText.getText().toString(), setRadix).toString(2).toUpperCase());
            octText.setText(new BigInteger(inputText.getText().toString(), setRadix).toString(8).toUpperCase());
            decText.setText(new BigInteger(inputText.getText().toString(), setRadix).toString(10).toUpperCase());
            hexText.setText(new BigInteger(inputText.getText().toString(), setRadix).toString(16).toUpperCase());
        }catch (Exception e){
            Log.e("Error",e.toString());
        }
    }

    private void initOutputResult(){
        inputText.setText("0");
        binText.setText("0");
        octText.setText("0");
        decText.setText("0");
        hexText.setText("0");
    }

    private void setButtonEnabled(int radix){
        inputText.setText("");
        initOutputResult();
        if(radix == 2){
            for(int i = 0 ;i<2;i++){
                button[i].setEnabled(true);
                button[i].setTextColor(Color.WHITE);

            }

            for(int i = 2 ;i<16;i++){
                button[i].setEnabled(false);
                button[i].setTextColor(Color.GRAY);
            }
        }
        if(radix==10){
            for(int i = 0 ;i<10;i++){
                button[i].setEnabled(true);
                button[i].setTextColor(Color.WHITE);
            }
            for(int i = 10 ;i<16;i++){
                button[i].setEnabled(false);
                button[i].setTextColor(Color.GRAY);
            }
        }

        if(radix==8){
            for(int i = 0 ;i<8;i++){
                button[i].setEnabled(true);
                button[i].setTextColor(Color.WHITE);
            }
            for(int i = 8 ;i<16;i++){
                button[i].setEnabled(false);
                button[i].setTextColor(Color.GRAY);
            }
        }
        if(radix==16){
            for(int i = 0 ;i<16;i++){
                button[i].setEnabled(true);
                button[i].setTextColor(Color.WHITE);
            }
        }

    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_main);

        //设置按钮
        button[0] = (Button)findViewById(R.id.num0);
        button[1] = (Button)findViewById(R.id.num1);
        button[2] = (Button)findViewById(R.id.num2);
        button[3] = (Button)findViewById(R.id.num3);
        button[4] = (Button)findViewById(R.id.num4);
        button[5] = (Button)findViewById(R.id.num5);
        button[6] = (Button)findViewById(R.id.num6);
        button[7] = (Button)findViewById(R.id.num7);
        button[8] = (Button)findViewById(R.id.num8);
        button[9] = (Button)findViewById(R.id.num9);
        button[10] = (Button)findViewById(R.id.num10);
        button[11] = (Button)findViewById(R.id.num11);
        button[12] = (Button)findViewById(R.id.num12);
        button[13] = (Button)findViewById(R.id.num13);
        button[14] = (Button)findViewById(R.id.num14);
        button[15] = (Button)findViewById(R.id.num15);
        button[16] = (Button)findViewById(R.id.clear);
        button[17] = (Button)findViewById(R.id.ce);
        inputText = (TextView)findViewById(R.id.input);
        binText = (TextView)findViewById(R.id.binText);
        octText = (TextView)findViewById(R.id.octText);
        decText = (TextView)findViewById(R.id.decText);
        hexText = (TextView)findViewById(R.id.hexText);

        bfConvertText = (TextView)findViewById(R.id.beforeConvertText);
        afConvertText = (TextView)findViewById(R.id.afterConvertText);

        Animation buttonScale = new ScaleAnimation(0.0f,1f, 0.0f, 1f,
                Animation.RELATIVE_TO_SELF, 0.5f, Animation.RELATIVE_TO_SELF, 0.5f);
        buttonScale.setDuration(1000);
        for(int i = 0;i<18;i++){
            button[i].setAnimation(buttonScale);
        }
        binText.setAnimation(buttonScale);
        octText.setAnimation(buttonScale);
        decText.setAnimation(buttonScale);
        hexText.setAnimation(buttonScale);
        inputText.setAnimation(buttonScale);

        leftList = (ListView)findViewById(R.id.left_drawer);
        rightList = (ListView)findViewById(R.id.right_drawer);
        seekBar = (SeekBar)findViewById(R.id.seekBar);
        backLayout = (TableLayout)findViewById(R.id.bkgLayout);
        Animation backAnimation = new AlphaAnimation(0f,1.0f);
        backAnimation.setDuration(1000);
        backLayout.setAnimation(backAnimation);

        try {
            SharedPreferences sharedata = getSharedPreferences("data", 0);
            backLayout.setBackgroundColor(Color.rgb(Integer.valueOf(sharedata.getString("red", null)),
                    Integer.valueOf(sharedata.getString("green", null)),Integer.valueOf(sharedata.getString("blue", null))));
        }catch (Exception e){
            Log.e("Error",e.getMessage());
        }


        seekBar.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int progress, boolean fromUser) {
                valRed = new Random().nextInt(255);
                valGreen = new Random().nextInt(255);
                valBlue = new Random().nextInt(255);
                backLayout.setBackgroundColor(Color.rgb(valRed, valGreen, valBlue));
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {

            }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {
                SharedPreferences.Editor sharedata = getSharedPreferences("data", 0).edit();
                sharedata.putString("red", valRed + "");
                sharedata.putString("green", valGreen + "");
                sharedata.putString("blue", valBlue + "");
                sharedata.commit();
            }
        });

        //设置ListView
        leftListItem = new ArrayList<HashMap<String,Object>>();
        rightListItem = new ArrayList<HashMap<String,Object>>();
        addItem(R.drawable.ic_bin,getString(R.string.bin),leftListItem);
        addItem(R.drawable.ic_oct,getString(R.string.oct),leftListItem);
        addItem(R.drawable.ic_dec,getString(R.string.dec),leftListItem);
        addItem(R.drawable.ic_hex,getString(R.string.hex),leftListItem);
        addItem(R.drawable.ic_bin,getString(R.string.bin),rightListItem);
        addItem(R.drawable.ic_oct,getString(R.string.oct),rightListItem);
        addItem(R.drawable.ic_dec,getString(R.string.dec),rightListItem);
        addItem(R.drawable.ic_hex,getString(R.string.hex),rightListItem);

        leftListAdapter = new SimpleAdapter(this, leftListItem, R.layout.drawer_layout,
                new String[]{"image","title"},
                new int[]{R.id.ItemImage,R.id.ItemTitle});
        rightListAdapter = new SimpleAdapter(this, leftListItem, R.layout.drawer_layout,
                new String[]{"image","title"},
                new int[]{R.id.ItemImage,R.id.ItemTitle});
        leftList.setAdapter(leftListAdapter);
        rightList.setAdapter(rightListAdapter);


        leftList.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                HashMap<String, Object> map = (HashMap<String, Object>) leftListAdapter.getItem(position);
                setButtonEnabled(10);
                startConver();
            }
        });

        rightList.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                HashMap<String, Object> map = (HashMap<String, Object>) rightListAdapter.getItem(position);

                startConver();
            }
        });

        binText.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                initOutputResult();
                setButtonEnabled(2);
                setRadix = 2;
                binText.setTextColor(Color.parseColor("#7dffffff"));
                octText.setTextColor(Color.parseColor("#ffffffff"));
                decText.setTextColor(Color.parseColor("#ffffffff"));
                hexText.setTextColor(Color.parseColor("#ffffffff"));
            }
        });
        octText.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                initOutputResult();
                setButtonEnabled(8);
                setRadix=8;
                binText.setTextColor(Color.parseColor("#ffffffff"));
                octText.setTextColor(Color.parseColor("#7dffffff"));
                decText.setTextColor(Color.parseColor("#ffffffff"));
                hexText.setTextColor(Color.parseColor("#ffffffff"));
            }
        });
        decText.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                initOutputResult();
                setButtonEnabled(10);
                setRadix=10;
                binText.setTextColor(Color.parseColor("#ffffffff"));
                octText.setTextColor(Color.parseColor("#ffffffff"));
                decText.setTextColor(Color.parseColor("#7dffffff"));
                hexText.setTextColor(Color.parseColor("#ffffffff"));
            }
        });
        hexText.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                initOutputResult();
                setButtonEnabled(16);
                setRadix=16;
                binText.setTextColor(Color.parseColor("#ffffffff"));
                octText.setTextColor(Color.parseColor("#ffffffff"));
                decText.setTextColor(Color.parseColor("#ffffffff"));
                hexText.setTextColor(Color.parseColor("#7dffffff"));
            }
        });

        binText.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {

                openAlertDialog(binText.getText()).show();

                return true;
            }
        });
        octText.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {

                openAlertDialog(octText.getText()).show();

                return true;
            }
        });
        decText.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {

                openAlertDialog(decText.getText()).show();

                return true;
            }
        });
        hexText.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {

                openAlertDialog(hexText.getText()).show();

                return true;
            }
        });


        inputText.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {

            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                if(inputText.getText().length()>0)
                {
                    startConver();
                } else
                    initOutputResult();
            }

            @Override
            public void afterTextChanged(Editable s) {

            }
        });

        numClickListener nc = new numClickListener();
        //设置监听
        for(Button ac : button){
            ac.setOnClickListener(nc);

        }
        setButtonEnabled(10);

    }



    private AlertDialog openAlertDialog(final CharSequence cs){

        AlertDialog.Builder builder = new AlertDialog.Builder(MainActivity.this,AlertDialog.THEME_DEVICE_DEFAULT_LIGHT);
        builder.setTitle("结果");
        builder.setMessage(cs);

        builder.setNegativeButton("关闭", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {

            }
        });
        builder.setPositiveButton("复制", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                ClipboardManager clipboardManager = (ClipboardManager) getSystemService(CLIPBOARD_SERVICE);
                clipboardManager.setText(cs);
                Toast.makeText(MainActivity.this,"结果已经复制到剪贴板",Toast.LENGTH_SHORT).show();
            }
        });
        builder.setIcon(R.mipmap.ic_launcher);
        AlertDialog alertDialog = builder.create();


        return alertDialog;

    }


    class numClickListener implements View.OnClickListener {

        @Override
        public void onClick(View v) {
            Button btn  = (Button) v;
            String input  = btn.getText().toString();
            Animation buttonScale = new ScaleAnimation(1f,0.8f, 1.0f, 0.8f,
                    Animation.RELATIVE_TO_SELF, 0.5f, Animation.RELATIVE_TO_SELF, 0.5f);
            buttonScale.setDuration(50);
            buttonScale.setRepeatMode(ScaleAnimation.REVERSE);
            buttonScale.setRepeatCount(1);
            v.startAnimation(buttonScale);


            if(input.equals("CLEAR")){

                Animation animation = new AlphaAnimation(1.0f,0.0f);
                animation.setRepeatMode(Animation.REVERSE);
                animation.setRepeatCount(1);
                animation.setDuration(300);
                animation.setAnimationListener(new Animation.AnimationListener() {
                    @Override
                    public void onAnimationStart(Animation animation) {

                    }

                    @Override
                    public void onAnimationEnd(Animation animation) {

                    }

                    @Override
                    public void onAnimationRepeat(Animation animation) {
                        initOutputResult();
                    }
                });
                inputText.startAnimation(animation);
                binText.startAnimation(animation);
                octText.startAnimation(animation);
                decText.startAnimation(animation);
                hexText.startAnimation(animation);

            }else if(input.equals("CE")){
                if(inputText.getText().length()>0)
                    inputText.setText(inputText.getText().subSequence(0,inputText.getText().length()-1));
            }
            else {
                if(input.equals("0")&&inputText.getText().toString().trim().equals("0"))
                    return;
                if(inputText.getText().toString().trim().equals("0")){
                    inputText.setText(input);
                    return;
                }
                inputText.append(input);
            }
        }
    }

    boolean isClosing = false;
    @Override
    public void onBackPressed() {
        //super.onBackPressed();
        if(isClosing==false){
            isClosing=true;
            Animation backAnimation = new AlphaAnimation(1f,0.0f);
            backAnimation.setDuration(1000);
            backLayout.startAnimation(backAnimation);
            Animation buttonScale = new ScaleAnimation(1f,0.0f, 1.0f, 0.0f,
                    Animation.RELATIVE_TO_SELF, 0.5f, Animation.RELATIVE_TO_SELF, 0.5f);
            buttonScale.setDuration(1000);
            for(int i =0;i<18;i++){
                button[i].startAnimation(buttonScale);
            }
            binText.startAnimation(buttonScale);
            octText.startAnimation(buttonScale);
            decText.startAnimation(buttonScale);
            hexText.startAnimation(buttonScale);
            inputText.startAnimation(buttonScale);
            buttonScale.setAnimationListener(new Animation.AnimationListener() {
                @Override
                public void onAnimationStart(Animation animation) {

                }

                @Override
                public void onAnimationEnd(Animation animation) {
                    System.exit(0);
                }

                @Override
                public void onAnimationRepeat(Animation animation) {

                }
            });
        }


    }
}

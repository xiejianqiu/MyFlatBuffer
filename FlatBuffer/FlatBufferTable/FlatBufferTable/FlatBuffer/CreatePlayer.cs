// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CreatePlayer : Table {
  public static FB_CreatePlayer GetRootAsFB_CreatePlayer(ByteBuffer _bb) { return GetRootAsFB_CreatePlayer(_bb, new FB_CreatePlayer()); }
  public static FB_CreatePlayer GetRootAsFB_CreatePlayer(ByteBuffer _bb, FB_CreatePlayer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CreatePlayer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MenPai { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Sex { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int CharModelID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int WeapenModelID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float CharOffsetX { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CharOffsetY { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CharOffsetZ { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CharRotateY { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public string ScenePath { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public int IdleAniID { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ShowAniID { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LoginAnimID { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LoginIdleAnimID { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float SelectFarCameraOffsetX { get { int o = __offset(32); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SelectFarCameraOffsetY { get { int o = __offset(34); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SelectFarCameraOffsetZ { get { int o = __offset(36); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SelectFarCameraRotateX { get { int o = __offset(38); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SelectFarCameraRotateY { get { int o = __offset(40); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SelectFarCameraRotateZ { get { int o = __offset(42); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SelectCloseCameraOffsetX { get { int o = __offset(44); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SelectCloseCameraOffsetY { get { int o = __offset(46); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SelectCloseCameraOffsetZ { get { int o = __offset(48); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SelectCloseCameraRotateX { get { int o = __offset(50); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SelectCloseCameraRotateY { get { int o = __offset(52); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SelectCloseCameraRotateZ { get { int o = __offset(54); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CreateCameraOffsetX { get { int o = __offset(56); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CreateCameraOffsetY { get { int o = __offset(58); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CreateCameraOffsetZ { get { int o = __offset(60); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CreateCameraRotateX { get { int o = __offset(62); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CreateCameraRotateY { get { int o = __offset(64); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CreateCameraRotateZ { get { int o = __offset(66); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int BGMusic { get { int o = __offset(68); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string CameraBlurAnima { get { int o = __offset(70); return o != 0 ? __string(o + bb_pos) : null; } }
  public string BloodCameraBlurAnim { get { int o = __offset(72); return o != 0 ? __string(o + bb_pos) : null; } }
  public int BloodPossessedModelId { get { int o = __offset(74); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SoundID { get { int o = __offset(76); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BloodSoundID { get { int o = __offset(78); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ChangeMenPaiItemId { get { int o = __offset(80); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string CamBindPoint { get { int o = __offset(82); return o != 0 ? __string(o + bb_pos) : null; } }
  public string CamXueMaiBindPoint { get { int o = __offset(84); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UISpecialHideID { get { int o = __offset(86); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float KFCameraFieldOfView { get { int o = __offset(88); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float KFCameraNearPosY { get { int o = __offset(90); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float KFCameraNearPosZ { get { int o = __offset(92); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float KFCameraNearRotateX { get { int o = __offset(94); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float KFCameraFarPosY { get { int o = __offset(96); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float KFCameraFarPosZ { get { int o = __offset(98); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float KFCameraFarRotateX { get { int o = __offset(100); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float XueMaiCameraNearPosX { get { int o = __offset(102); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float XueMaiCameraNearPosY { get { int o = __offset(104); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float XueMaiCameraNearPosZ { get { int o = __offset(106); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float XueMaiCameraNearRotoX { get { int o = __offset(108); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float XueMaiCameraNearRotoY { get { int o = __offset(110); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float XueMaiCameraNearRotoZ { get { int o = __offset(112); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int FaceItemId { get { int o = __offset(114); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FaceNum { get { int o = __offset(116); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float KneadfaceUIPosIndex { get { int o = __offset(118); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public string CreateBloomColor { get { int o = __offset(120); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_CreatePlayer> CreateFB_CreatePlayer(FlatBufferBuilder builder,
      int ID = 0,
      int MenPai = 0,
      int Sex = 1,
      int CharModelID = 0,
      int WeapenModelID = 0,
      float CharOffsetX = 0,
      float CharOffsetY = 0,
      float CharOffsetZ = 0,
      float CharRotateY = 0,
      StringOffset ScenePath = default(StringOffset),
      int IdleAniID = 0,
      int ShowAniID = 0,
      int LoginAnimID = -1,
      int LoginIdleAnimID = -1,
      float SelectFarCameraOffsetX = 0,
      float SelectFarCameraOffsetY = 0,
      float SelectFarCameraOffsetZ = 0,
      float SelectFarCameraRotateX = 0,
      float SelectFarCameraRotateY = 0,
      float SelectFarCameraRotateZ = 0,
      float SelectCloseCameraOffsetX = 0,
      float SelectCloseCameraOffsetY = 0,
      float SelectCloseCameraOffsetZ = 0,
      float SelectCloseCameraRotateX = 0,
      float SelectCloseCameraRotateY = 0,
      float SelectCloseCameraRotateZ = 0,
      float CreateCameraOffsetX = 0,
      float CreateCameraOffsetY = 0,
      float CreateCameraOffsetZ = 0,
      float CreateCameraRotateX = 0,
      float CreateCameraRotateY = 0,
      float CreateCameraRotateZ = 0,
      int BGMusic = -1,
      StringOffset CameraBlurAnima = default(StringOffset),
      StringOffset BloodCameraBlurAnim = default(StringOffset),
      int BloodPossessedModelId = -1,
      int SoundID = -1,
      int BloodSoundID = -1,
      int ChangeMenPaiItemId = -1,
      StringOffset Cam_BindPoint = default(StringOffset),
      StringOffset Cam_XueMaiBindPoint = default(StringOffset),
      int UISpecialHideID = -1,
      float KFCameraFieldOfView = 0,
      float KFCameraNearPosY = 0,
      float KFCameraNearPosZ = 0,
      float KFCameraNearRotateX = 0,
      float KFCameraFarPosY = 0,
      float KFCameraFarPosZ = 0,
      float KFCameraFarRotateX = 0,
      float XueMaiCameraNearPosX = 0,
      float XueMaiCameraNearPosY = 0,
      float XueMaiCameraNearPosZ = 0,
      float XueMaiCameraNearRotoX = 0,
      float XueMaiCameraNearRotoY = 0,
      float XueMaiCameraNearRotoZ = 0,
      int FaceItemId = -1,
      int FaceNum = -1,
      float KneadfaceUIPosIndex = 0,
      StringOffset CreateBloomColor = default(StringOffset)) {
    builder.StartObject(59);
    FB_CreatePlayer.AddCreateBloomColor(builder, CreateBloomColor);
    FB_CreatePlayer.AddKneadfaceUIPosIndex(builder, KneadfaceUIPosIndex);
    FB_CreatePlayer.AddFaceNum(builder, FaceNum);
    FB_CreatePlayer.AddFaceItemId(builder, FaceItemId);
    FB_CreatePlayer.AddXueMaiCameraNearRotoZ(builder, XueMaiCameraNearRotoZ);
    FB_CreatePlayer.AddXueMaiCameraNearRotoY(builder, XueMaiCameraNearRotoY);
    FB_CreatePlayer.AddXueMaiCameraNearRotoX(builder, XueMaiCameraNearRotoX);
    FB_CreatePlayer.AddXueMaiCameraNearPosZ(builder, XueMaiCameraNearPosZ);
    FB_CreatePlayer.AddXueMaiCameraNearPosY(builder, XueMaiCameraNearPosY);
    FB_CreatePlayer.AddXueMaiCameraNearPosX(builder, XueMaiCameraNearPosX);
    FB_CreatePlayer.AddKFCameraFarRotateX(builder, KFCameraFarRotateX);
    FB_CreatePlayer.AddKFCameraFarPosZ(builder, KFCameraFarPosZ);
    FB_CreatePlayer.AddKFCameraFarPosY(builder, KFCameraFarPosY);
    FB_CreatePlayer.AddKFCameraNearRotateX(builder, KFCameraNearRotateX);
    FB_CreatePlayer.AddKFCameraNearPosZ(builder, KFCameraNearPosZ);
    FB_CreatePlayer.AddKFCameraNearPosY(builder, KFCameraNearPosY);
    FB_CreatePlayer.AddKFCameraFieldOfView(builder, KFCameraFieldOfView);
    FB_CreatePlayer.AddUISpecialHideID(builder, UISpecialHideID);
    FB_CreatePlayer.AddCamXueMaiBindPoint(builder, Cam_XueMaiBindPoint);
    FB_CreatePlayer.AddCamBindPoint(builder, Cam_BindPoint);
    FB_CreatePlayer.AddChangeMenPaiItemId(builder, ChangeMenPaiItemId);
    FB_CreatePlayer.AddBloodSoundID(builder, BloodSoundID);
    FB_CreatePlayer.AddSoundID(builder, SoundID);
    FB_CreatePlayer.AddBloodPossessedModelId(builder, BloodPossessedModelId);
    FB_CreatePlayer.AddBloodCameraBlurAnim(builder, BloodCameraBlurAnim);
    FB_CreatePlayer.AddCameraBlurAnima(builder, CameraBlurAnima);
    FB_CreatePlayer.AddBGMusic(builder, BGMusic);
    FB_CreatePlayer.AddCreateCameraRotateZ(builder, CreateCameraRotateZ);
    FB_CreatePlayer.AddCreateCameraRotateY(builder, CreateCameraRotateY);
    FB_CreatePlayer.AddCreateCameraRotateX(builder, CreateCameraRotateX);
    FB_CreatePlayer.AddCreateCameraOffsetZ(builder, CreateCameraOffsetZ);
    FB_CreatePlayer.AddCreateCameraOffsetY(builder, CreateCameraOffsetY);
    FB_CreatePlayer.AddCreateCameraOffsetX(builder, CreateCameraOffsetX);
    FB_CreatePlayer.AddSelectCloseCameraRotateZ(builder, SelectCloseCameraRotateZ);
    FB_CreatePlayer.AddSelectCloseCameraRotateY(builder, SelectCloseCameraRotateY);
    FB_CreatePlayer.AddSelectCloseCameraRotateX(builder, SelectCloseCameraRotateX);
    FB_CreatePlayer.AddSelectCloseCameraOffsetZ(builder, SelectCloseCameraOffsetZ);
    FB_CreatePlayer.AddSelectCloseCameraOffsetY(builder, SelectCloseCameraOffsetY);
    FB_CreatePlayer.AddSelectCloseCameraOffsetX(builder, SelectCloseCameraOffsetX);
    FB_CreatePlayer.AddSelectFarCameraRotateZ(builder, SelectFarCameraRotateZ);
    FB_CreatePlayer.AddSelectFarCameraRotateY(builder, SelectFarCameraRotateY);
    FB_CreatePlayer.AddSelectFarCameraRotateX(builder, SelectFarCameraRotateX);
    FB_CreatePlayer.AddSelectFarCameraOffsetZ(builder, SelectFarCameraOffsetZ);
    FB_CreatePlayer.AddSelectFarCameraOffsetY(builder, SelectFarCameraOffsetY);
    FB_CreatePlayer.AddSelectFarCameraOffsetX(builder, SelectFarCameraOffsetX);
    FB_CreatePlayer.AddLoginIdleAnimID(builder, LoginIdleAnimID);
    FB_CreatePlayer.AddLoginAnimID(builder, LoginAnimID);
    FB_CreatePlayer.AddShowAniID(builder, ShowAniID);
    FB_CreatePlayer.AddIdleAniID(builder, IdleAniID);
    FB_CreatePlayer.AddScenePath(builder, ScenePath);
    FB_CreatePlayer.AddCharRotateY(builder, CharRotateY);
    FB_CreatePlayer.AddCharOffsetZ(builder, CharOffsetZ);
    FB_CreatePlayer.AddCharOffsetY(builder, CharOffsetY);
    FB_CreatePlayer.AddCharOffsetX(builder, CharOffsetX);
    FB_CreatePlayer.AddWeapenModelID(builder, WeapenModelID);
    FB_CreatePlayer.AddCharModelID(builder, CharModelID);
    FB_CreatePlayer.AddSex(builder, Sex);
    FB_CreatePlayer.AddMenPai(builder, MenPai);
    FB_CreatePlayer.AddID(builder, ID);
    return FB_CreatePlayer.EndFB_CreatePlayer(builder);
  }

  public static void StartFB_CreatePlayer(FlatBufferBuilder builder) { builder.StartObject(59); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(1, MenPai, 0); }
  public static void AddSex(FlatBufferBuilder builder, int Sex) { builder.AddInt(2, Sex, 1); }
  public static void AddCharModelID(FlatBufferBuilder builder, int CharModelID) { builder.AddInt(3, CharModelID, 0); }
  public static void AddWeapenModelID(FlatBufferBuilder builder, int WeapenModelID) { builder.AddInt(4, WeapenModelID, 0); }
  public static void AddCharOffsetX(FlatBufferBuilder builder, float CharOffsetX) { builder.AddFloat(5, CharOffsetX, 0); }
  public static void AddCharOffsetY(FlatBufferBuilder builder, float CharOffsetY) { builder.AddFloat(6, CharOffsetY, 0); }
  public static void AddCharOffsetZ(FlatBufferBuilder builder, float CharOffsetZ) { builder.AddFloat(7, CharOffsetZ, 0); }
  public static void AddCharRotateY(FlatBufferBuilder builder, float CharRotateY) { builder.AddFloat(8, CharRotateY, 0); }
  public static void AddScenePath(FlatBufferBuilder builder, StringOffset ScenePathOffset) { builder.AddOffset(9, ScenePathOffset.Value, 0); }
  public static void AddIdleAniID(FlatBufferBuilder builder, int IdleAniID) { builder.AddInt(10, IdleAniID, 0); }
  public static void AddShowAniID(FlatBufferBuilder builder, int ShowAniID) { builder.AddInt(11, ShowAniID, 0); }
  public static void AddLoginAnimID(FlatBufferBuilder builder, int LoginAnimID) { builder.AddInt(12, LoginAnimID, -1); }
  public static void AddLoginIdleAnimID(FlatBufferBuilder builder, int LoginIdleAnimID) { builder.AddInt(13, LoginIdleAnimID, -1); }
  public static void AddSelectFarCameraOffsetX(FlatBufferBuilder builder, float SelectFarCameraOffsetX) { builder.AddFloat(14, SelectFarCameraOffsetX, 0); }
  public static void AddSelectFarCameraOffsetY(FlatBufferBuilder builder, float SelectFarCameraOffsetY) { builder.AddFloat(15, SelectFarCameraOffsetY, 0); }
  public static void AddSelectFarCameraOffsetZ(FlatBufferBuilder builder, float SelectFarCameraOffsetZ) { builder.AddFloat(16, SelectFarCameraOffsetZ, 0); }
  public static void AddSelectFarCameraRotateX(FlatBufferBuilder builder, float SelectFarCameraRotateX) { builder.AddFloat(17, SelectFarCameraRotateX, 0); }
  public static void AddSelectFarCameraRotateY(FlatBufferBuilder builder, float SelectFarCameraRotateY) { builder.AddFloat(18, SelectFarCameraRotateY, 0); }
  public static void AddSelectFarCameraRotateZ(FlatBufferBuilder builder, float SelectFarCameraRotateZ) { builder.AddFloat(19, SelectFarCameraRotateZ, 0); }
  public static void AddSelectCloseCameraOffsetX(FlatBufferBuilder builder, float SelectCloseCameraOffsetX) { builder.AddFloat(20, SelectCloseCameraOffsetX, 0); }
  public static void AddSelectCloseCameraOffsetY(FlatBufferBuilder builder, float SelectCloseCameraOffsetY) { builder.AddFloat(21, SelectCloseCameraOffsetY, 0); }
  public static void AddSelectCloseCameraOffsetZ(FlatBufferBuilder builder, float SelectCloseCameraOffsetZ) { builder.AddFloat(22, SelectCloseCameraOffsetZ, 0); }
  public static void AddSelectCloseCameraRotateX(FlatBufferBuilder builder, float SelectCloseCameraRotateX) { builder.AddFloat(23, SelectCloseCameraRotateX, 0); }
  public static void AddSelectCloseCameraRotateY(FlatBufferBuilder builder, float SelectCloseCameraRotateY) { builder.AddFloat(24, SelectCloseCameraRotateY, 0); }
  public static void AddSelectCloseCameraRotateZ(FlatBufferBuilder builder, float SelectCloseCameraRotateZ) { builder.AddFloat(25, SelectCloseCameraRotateZ, 0); }
  public static void AddCreateCameraOffsetX(FlatBufferBuilder builder, float CreateCameraOffsetX) { builder.AddFloat(26, CreateCameraOffsetX, 0); }
  public static void AddCreateCameraOffsetY(FlatBufferBuilder builder, float CreateCameraOffsetY) { builder.AddFloat(27, CreateCameraOffsetY, 0); }
  public static void AddCreateCameraOffsetZ(FlatBufferBuilder builder, float CreateCameraOffsetZ) { builder.AddFloat(28, CreateCameraOffsetZ, 0); }
  public static void AddCreateCameraRotateX(FlatBufferBuilder builder, float CreateCameraRotateX) { builder.AddFloat(29, CreateCameraRotateX, 0); }
  public static void AddCreateCameraRotateY(FlatBufferBuilder builder, float CreateCameraRotateY) { builder.AddFloat(30, CreateCameraRotateY, 0); }
  public static void AddCreateCameraRotateZ(FlatBufferBuilder builder, float CreateCameraRotateZ) { builder.AddFloat(31, CreateCameraRotateZ, 0); }
  public static void AddBGMusic(FlatBufferBuilder builder, int BGMusic) { builder.AddInt(32, BGMusic, -1); }
  public static void AddCameraBlurAnima(FlatBufferBuilder builder, StringOffset CameraBlurAnimaOffset) { builder.AddOffset(33, CameraBlurAnimaOffset.Value, 0); }
  public static void AddBloodCameraBlurAnim(FlatBufferBuilder builder, StringOffset BloodCameraBlurAnimOffset) { builder.AddOffset(34, BloodCameraBlurAnimOffset.Value, 0); }
  public static void AddBloodPossessedModelId(FlatBufferBuilder builder, int BloodPossessedModelId) { builder.AddInt(35, BloodPossessedModelId, -1); }
  public static void AddSoundID(FlatBufferBuilder builder, int SoundID) { builder.AddInt(36, SoundID, -1); }
  public static void AddBloodSoundID(FlatBufferBuilder builder, int BloodSoundID) { builder.AddInt(37, BloodSoundID, -1); }
  public static void AddChangeMenPaiItemId(FlatBufferBuilder builder, int ChangeMenPaiItemId) { builder.AddInt(38, ChangeMenPaiItemId, -1); }
  public static void AddCamBindPoint(FlatBufferBuilder builder, StringOffset CamBindPointOffset) { builder.AddOffset(39, CamBindPointOffset.Value, 0); }
  public static void AddCamXueMaiBindPoint(FlatBufferBuilder builder, StringOffset CamXueMaiBindPointOffset) { builder.AddOffset(40, CamXueMaiBindPointOffset.Value, 0); }
  public static void AddUISpecialHideID(FlatBufferBuilder builder, int UISpecialHideID) { builder.AddInt(41, UISpecialHideID, -1); }
  public static void AddKFCameraFieldOfView(FlatBufferBuilder builder, float KFCameraFieldOfView) { builder.AddFloat(42, KFCameraFieldOfView, 0); }
  public static void AddKFCameraNearPosY(FlatBufferBuilder builder, float KFCameraNearPosY) { builder.AddFloat(43, KFCameraNearPosY, 0); }
  public static void AddKFCameraNearPosZ(FlatBufferBuilder builder, float KFCameraNearPosZ) { builder.AddFloat(44, KFCameraNearPosZ, 0); }
  public static void AddKFCameraNearRotateX(FlatBufferBuilder builder, float KFCameraNearRotateX) { builder.AddFloat(45, KFCameraNearRotateX, 0); }
  public static void AddKFCameraFarPosY(FlatBufferBuilder builder, float KFCameraFarPosY) { builder.AddFloat(46, KFCameraFarPosY, 0); }
  public static void AddKFCameraFarPosZ(FlatBufferBuilder builder, float KFCameraFarPosZ) { builder.AddFloat(47, KFCameraFarPosZ, 0); }
  public static void AddKFCameraFarRotateX(FlatBufferBuilder builder, float KFCameraFarRotateX) { builder.AddFloat(48, KFCameraFarRotateX, 0); }
  public static void AddXueMaiCameraNearPosX(FlatBufferBuilder builder, float XueMaiCameraNearPosX) { builder.AddFloat(49, XueMaiCameraNearPosX, 0); }
  public static void AddXueMaiCameraNearPosY(FlatBufferBuilder builder, float XueMaiCameraNearPosY) { builder.AddFloat(50, XueMaiCameraNearPosY, 0); }
  public static void AddXueMaiCameraNearPosZ(FlatBufferBuilder builder, float XueMaiCameraNearPosZ) { builder.AddFloat(51, XueMaiCameraNearPosZ, 0); }
  public static void AddXueMaiCameraNearRotoX(FlatBufferBuilder builder, float XueMaiCameraNearRotoX) { builder.AddFloat(52, XueMaiCameraNearRotoX, 0); }
  public static void AddXueMaiCameraNearRotoY(FlatBufferBuilder builder, float XueMaiCameraNearRotoY) { builder.AddFloat(53, XueMaiCameraNearRotoY, 0); }
  public static void AddXueMaiCameraNearRotoZ(FlatBufferBuilder builder, float XueMaiCameraNearRotoZ) { builder.AddFloat(54, XueMaiCameraNearRotoZ, 0); }
  public static void AddFaceItemId(FlatBufferBuilder builder, int FaceItemId) { builder.AddInt(55, FaceItemId, -1); }
  public static void AddFaceNum(FlatBufferBuilder builder, int FaceNum) { builder.AddInt(56, FaceNum, -1); }
  public static void AddKneadfaceUIPosIndex(FlatBufferBuilder builder, float KneadfaceUIPosIndex) { builder.AddFloat(57, KneadfaceUIPosIndex, 0); }
  public static void AddCreateBloomColor(FlatBufferBuilder builder, StringOffset CreateBloomColorOffset) { builder.AddOffset(58, CreateBloomColorOffset.Value, 0); }
  public static Offset<FB_CreatePlayer> EndFB_CreatePlayer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CreatePlayer>(o);
  }
};

public sealed class FB_CreatePlayerContainer : Table {
  public static FB_CreatePlayerContainer GetRootAsFB_CreatePlayerContainer(ByteBuffer _bb) { return GetRootAsFB_CreatePlayerContainer(_bb, new FB_CreatePlayerContainer()); }
  public static FB_CreatePlayerContainer GetRootAsFB_CreatePlayerContainer(ByteBuffer _bb, FB_CreatePlayerContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CreatePlayerContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CreatePlayerContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CreatePlayer GetItems(int j) { return GetItems(new FB_CreatePlayer(), j); }
  public FB_CreatePlayer GetItems(FB_CreatePlayer obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CreatePlayerContainer> CreateFB_CreatePlayerContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CreatePlayerContainer.AddItems(builder, items);
    return FB_CreatePlayerContainer.EndFB_CreatePlayerContainer(builder);
  }

  public static void StartFB_CreatePlayerContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CreatePlayer>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CreatePlayerContainer> EndFB_CreatePlayerContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CreatePlayerContainer>(o);
  }
  public static void FinishFB_CreatePlayerContainerBuffer(FlatBufferBuilder builder, Offset<FB_CreatePlayerContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}

PGDMP      2                |           mydb    16.3    16.3 P    G           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            H           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            I           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            J           1262    16398    mydb    DATABASE        CREATE DATABASE mydb WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United Kingdom.936';
    DROP DATABASE mydb;
                postgres    false            �            1259    16522 	   dicomfile    TABLE        CREATE TABLE public.dicomfile (
    dicom_id integer NOT NULL,
    organ_id integer NOT NULL,
    dicom_data bytea NOT NULL
);
    DROP TABLE public.dicomfile;
       public         heap    postgres    false            �            1259    16521    dicomfile_dicom_id_seq    SEQUENCE     �   CREATE SEQUENCE public.dicomfile_dicom_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.dicomfile_dicom_id_seq;
       public          postgres    false    233            K           0    0    dicomfile_dicom_id_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.dicomfile_dicom_id_seq OWNED BY public.dicomfile.dicom_id;
          public          postgres    false    232            �            1259    16407    donor    TABLE     �   CREATE TABLE public.donor (
    donor_id integer NOT NULL,
    age integer NOT NULL,
    date_of_death date NOT NULL,
    cause_of_death text NOT NULL
);
    DROP TABLE public.donor;
       public         heap    postgres    false            �            1259    16406    donor_donor_id_seq    SEQUENCE     �   CREATE SEQUENCE public.donor_donor_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.donor_donor_id_seq;
       public          postgres    false    216            L           0    0    donor_donor_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.donor_donor_id_seq OWNED BY public.donor.donor_id;
          public          postgres    false    215            �            1259    16466    model3d    TABLE     k   CREATE TABLE public.model3d (
    model_id integer NOT NULL,
    organ_id integer,
    model_data bytea
);
    DROP TABLE public.model3d;
       public         heap    postgres    false            �            1259    16465    model3d_model_id_seq    SEQUENCE     �   CREATE SEQUENCE public.model3d_model_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.model3d_model_id_seq;
       public          postgres    false    225            M           0    0    model3d_model_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.model3d_model_id_seq OWNED BY public.model3d.model_id;
          public          postgres    false    224            �            1259    16426    organ    TABLE     w   CREATE TABLE public.organ (
    organ_id integer NOT NULL,
    donor_id integer NOT NULL,
    organ_name_id integer
);
    DROP TABLE public.organ;
       public         heap    postgres    false            �            1259    16425    organ_organ_id_seq    SEQUENCE     �   CREATE SEQUENCE public.organ_organ_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.organ_organ_id_seq;
       public          postgres    false    218            N           0    0    organ_organ_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.organ_organ_id_seq OWNED BY public.organ.organ_id;
          public          postgres    false    217            �            1259    16457 	   organname    TABLE     [   CREATE TABLE public.organname (
    organ_name_id integer NOT NULL,
    organ_name text
);
    DROP TABLE public.organname;
       public         heap    postgres    false            �            1259    16456    organname_organ_name_id_seq    SEQUENCE     �   CREATE SEQUENCE public.organname_organ_name_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public.organname_organ_name_id_seq;
       public          postgres    false    223            O           0    0    organname_organ_name_id_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public.organname_organ_name_id_seq OWNED BY public.organname.organ_name_id;
          public          postgres    false    222            �            1259    16446    organtag    TABLE     ]   CREATE TABLE public.organtag (
    organ_id integer NOT NULL,
    tag_id integer NOT NULL
);
    DROP TABLE public.organtag;
       public         heap    postgres    false            �            1259    16494    segmentation    TABLE     ~   CREATE TABLE public.segmentation (
    segmentation_id integer NOT NULL,
    slice_id integer,
    segmentation_data bytea
);
     DROP TABLE public.segmentation;
       public         heap    postgres    false            �            1259    16493     segmentation_segmentation_id_seq    SEQUENCE     �   CREATE SEQUENCE public.segmentation_segmentation_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 7   DROP SEQUENCE public.segmentation_segmentation_id_seq;
       public          postgres    false    229            P           0    0     segmentation_segmentation_id_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE public.segmentation_segmentation_id_seq OWNED BY public.segmentation.segmentation_id;
          public          postgres    false    228            �            1259    16508 
   sliceimage    TABLE     �   CREATE TABLE public.sliceimage (
    slice_id integer NOT NULL,
    organ_id integer,
    dicom_id integer,
    image_data bytea,
    additional_info text
);
    DROP TABLE public.sliceimage;
       public         heap    postgres    false            �            1259    16507    sliceimage_slice_id_seq    SEQUENCE     �   CREATE SEQUENCE public.sliceimage_slice_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.sliceimage_slice_id_seq;
       public          postgres    false    231            Q           0    0    sliceimage_slice_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.sliceimage_slice_id_seq OWNED BY public.sliceimage.slice_id;
          public          postgres    false    230            �            1259    16438    tag    TABLE     U   CREATE TABLE public.tag (
    tag_id integer NOT NULL,
    tag_name text NOT NULL
);
    DROP TABLE public.tag;
       public         heap    postgres    false            �            1259    16437    tag_tag_id_seq    SEQUENCE     �   CREATE SEQUENCE public.tag_tag_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.tag_tag_id_seq;
       public          postgres    false    220            R           0    0    tag_tag_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.tag_tag_id_seq OWNED BY public.tag.tag_id;
          public          postgres    false    219            �            1259    16485 
   texturemap    TABLE     y   CREATE TABLE public.texturemap (
    texture_id integer NOT NULL,
    segmentation_id integer,
    texture_data bytea
);
    DROP TABLE public.texturemap;
       public         heap    postgres    false            �            1259    16484    texturemap_texture_id_seq    SEQUENCE     �   CREATE SEQUENCE public.texturemap_texture_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public.texturemap_texture_id_seq;
       public          postgres    false    227            S           0    0    texturemap_texture_id_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public.texturemap_texture_id_seq OWNED BY public.texturemap.texture_id;
          public          postgres    false    226            �           2604    16525    dicomfile dicom_id    DEFAULT     x   ALTER TABLE ONLY public.dicomfile ALTER COLUMN dicom_id SET DEFAULT nextval('public.dicomfile_dicom_id_seq'::regclass);
 A   ALTER TABLE public.dicomfile ALTER COLUMN dicom_id DROP DEFAULT;
       public          postgres    false    233    232    233            |           2604    16410    donor donor_id    DEFAULT     p   ALTER TABLE ONLY public.donor ALTER COLUMN donor_id SET DEFAULT nextval('public.donor_donor_id_seq'::regclass);
 =   ALTER TABLE public.donor ALTER COLUMN donor_id DROP DEFAULT;
       public          postgres    false    215    216    216            �           2604    16469    model3d model_id    DEFAULT     t   ALTER TABLE ONLY public.model3d ALTER COLUMN model_id SET DEFAULT nextval('public.model3d_model_id_seq'::regclass);
 ?   ALTER TABLE public.model3d ALTER COLUMN model_id DROP DEFAULT;
       public          postgres    false    225    224    225            }           2604    16429    organ organ_id    DEFAULT     p   ALTER TABLE ONLY public.organ ALTER COLUMN organ_id SET DEFAULT nextval('public.organ_organ_id_seq'::regclass);
 =   ALTER TABLE public.organ ALTER COLUMN organ_id DROP DEFAULT;
       public          postgres    false    217    218    218                       2604    16460    organname organ_name_id    DEFAULT     �   ALTER TABLE ONLY public.organname ALTER COLUMN organ_name_id SET DEFAULT nextval('public.organname_organ_name_id_seq'::regclass);
 F   ALTER TABLE public.organname ALTER COLUMN organ_name_id DROP DEFAULT;
       public          postgres    false    223    222    223            �           2604    16497    segmentation segmentation_id    DEFAULT     �   ALTER TABLE ONLY public.segmentation ALTER COLUMN segmentation_id SET DEFAULT nextval('public.segmentation_segmentation_id_seq'::regclass);
 K   ALTER TABLE public.segmentation ALTER COLUMN segmentation_id DROP DEFAULT;
       public          postgres    false    229    228    229            �           2604    16511    sliceimage slice_id    DEFAULT     z   ALTER TABLE ONLY public.sliceimage ALTER COLUMN slice_id SET DEFAULT nextval('public.sliceimage_slice_id_seq'::regclass);
 B   ALTER TABLE public.sliceimage ALTER COLUMN slice_id DROP DEFAULT;
       public          postgres    false    231    230    231            ~           2604    16441 
   tag tag_id    DEFAULT     h   ALTER TABLE ONLY public.tag ALTER COLUMN tag_id SET DEFAULT nextval('public.tag_tag_id_seq'::regclass);
 9   ALTER TABLE public.tag ALTER COLUMN tag_id DROP DEFAULT;
       public          postgres    false    220    219    220            �           2604    16488    texturemap texture_id    DEFAULT     ~   ALTER TABLE ONLY public.texturemap ALTER COLUMN texture_id SET DEFAULT nextval('public.texturemap_texture_id_seq'::regclass);
 D   ALTER TABLE public.texturemap ALTER COLUMN texture_id DROP DEFAULT;
       public          postgres    false    226    227    227            D          0    16522 	   dicomfile 
   TABLE DATA           C   COPY public.dicomfile (dicom_id, organ_id, dicom_data) FROM stdin;
    public          postgres    false    233   �Y       3          0    16407    donor 
   TABLE DATA           M   COPY public.donor (donor_id, age, date_of_death, cause_of_death) FROM stdin;
    public          postgres    false    216   �Y       <          0    16466    model3d 
   TABLE DATA           A   COPY public.model3d (model_id, organ_id, model_data) FROM stdin;
    public          postgres    false    225   �Y       5          0    16426    organ 
   TABLE DATA           B   COPY public.organ (organ_id, donor_id, organ_name_id) FROM stdin;
    public          postgres    false    218   Z       :          0    16457 	   organname 
   TABLE DATA           >   COPY public.organname (organ_name_id, organ_name) FROM stdin;
    public          postgres    false    223   ;Z       8          0    16446    organtag 
   TABLE DATA           4   COPY public.organtag (organ_id, tag_id) FROM stdin;
    public          postgres    false    221   �Z       @          0    16494    segmentation 
   TABLE DATA           T   COPY public.segmentation (segmentation_id, slice_id, segmentation_data) FROM stdin;
    public          postgres    false    229   �Z       B          0    16508 
   sliceimage 
   TABLE DATA           _   COPY public.sliceimage (slice_id, organ_id, dicom_id, image_data, additional_info) FROM stdin;
    public          postgres    false    231   �Z       7          0    16438    tag 
   TABLE DATA           /   COPY public.tag (tag_id, tag_name) FROM stdin;
    public          postgres    false    220   �Z       >          0    16485 
   texturemap 
   TABLE DATA           O   COPY public.texturemap (texture_id, segmentation_id, texture_data) FROM stdin;
    public          postgres    false    227   L[       T           0    0    dicomfile_dicom_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.dicomfile_dicom_id_seq', 1, false);
          public          postgres    false    232            U           0    0    donor_donor_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.donor_donor_id_seq', 1, true);
          public          postgres    false    215            V           0    0    model3d_model_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.model3d_model_id_seq', 1, false);
          public          postgres    false    224            W           0    0    organ_organ_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.organ_organ_id_seq', 1, true);
          public          postgres    false    217            X           0    0    organname_organ_name_id_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.organname_organ_name_id_seq', 6, true);
          public          postgres    false    222            Y           0    0     segmentation_segmentation_id_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public.segmentation_segmentation_id_seq', 1, false);
          public          postgres    false    228            Z           0    0    sliceimage_slice_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.sliceimage_slice_id_seq', 1, false);
          public          postgres    false    230            [           0    0    tag_tag_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.tag_tag_id_seq', 6, true);
          public          postgres    false    219            \           0    0    texturemap_texture_id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.texturemap_texture_id_seq', 1, false);
          public          postgres    false    226            �           2606    16529    dicomfile dicomfile_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.dicomfile
    ADD CONSTRAINT dicomfile_pkey PRIMARY KEY (dicom_id);
 B   ALTER TABLE ONLY public.dicomfile DROP CONSTRAINT dicomfile_pkey;
       public            postgres    false    233            �           2606    16412    donor donor_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.donor
    ADD CONSTRAINT donor_pkey PRIMARY KEY (donor_id);
 :   ALTER TABLE ONLY public.donor DROP CONSTRAINT donor_pkey;
       public            postgres    false    216            �           2606    16473    model3d model3d_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.model3d
    ADD CONSTRAINT model3d_pkey PRIMARY KEY (model_id);
 >   ALTER TABLE ONLY public.model3d DROP CONSTRAINT model3d_pkey;
       public            postgres    false    225            �           2606    16431    organ organ_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.organ
    ADD CONSTRAINT organ_pkey PRIMARY KEY (organ_id);
 :   ALTER TABLE ONLY public.organ DROP CONSTRAINT organ_pkey;
       public            postgres    false    218            �           2606    16464    organname organname_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.organname
    ADD CONSTRAINT organname_pkey PRIMARY KEY (organ_name_id);
 B   ALTER TABLE ONLY public.organname DROP CONSTRAINT organname_pkey;
       public            postgres    false    223            �           2606    16450    organtag organtag_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT organtag_pkey PRIMARY KEY (organ_id, tag_id);
 @   ALTER TABLE ONLY public.organtag DROP CONSTRAINT organtag_pkey;
       public            postgres    false    221    221            �           2606    16501    segmentation segmentation_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public.segmentation
    ADD CONSTRAINT segmentation_pkey PRIMARY KEY (segmentation_id);
 H   ALTER TABLE ONLY public.segmentation DROP CONSTRAINT segmentation_pkey;
       public            postgres    false    229            �           2606    16515    sliceimage sliceimage_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT sliceimage_pkey PRIMARY KEY (slice_id);
 D   ALTER TABLE ONLY public.sliceimage DROP CONSTRAINT sliceimage_pkey;
       public            postgres    false    231            �           2606    16443    tag tag_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.tag
    ADD CONSTRAINT tag_pkey PRIMARY KEY (tag_id);
 6   ALTER TABLE ONLY public.tag DROP CONSTRAINT tag_pkey;
       public            postgres    false    220            �           2606    16492    texturemap texturemap_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.texturemap
    ADD CONSTRAINT texturemap_pkey PRIMARY KEY (texture_id);
 D   ALTER TABLE ONLY public.texturemap DROP CONSTRAINT texturemap_pkey;
       public            postgres    false    227            �           2606    16535    sliceimage dicom_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT dicom_id FOREIGN KEY (dicom_id) REFERENCES public.dicomfile(dicom_id) ON DELETE CASCADE;
 =   ALTER TABLE ONLY public.sliceimage DROP CONSTRAINT dicom_id;
       public          postgres    false    231    233    4760            �           2606    16432    organ donor_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.organ
    ADD CONSTRAINT donor_id FOREIGN KEY (donor_id) REFERENCES public.donor(donor_id) ON DELETE CASCADE;
 8   ALTER TABLE ONLY public.organ DROP CONSTRAINT donor_id;
       public          postgres    false    4742    216    218            �           2606    16451    organtag organ_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;
 ;   ALTER TABLE ONLY public.organtag DROP CONSTRAINT organ_id;
       public          postgres    false    218    221    4744            �           2606    16474    model3d organ_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.model3d
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;
 :   ALTER TABLE ONLY public.model3d DROP CONSTRAINT organ_id;
       public          postgres    false    218    4744    225            �           2606    16516    sliceimage organ_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;
 =   ALTER TABLE ONLY public.sliceimage DROP CONSTRAINT organ_id;
       public          postgres    false    231    4744    218            �           2606    16530    dicomfile organ_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.dicomfile
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;
 <   ALTER TABLE ONLY public.dicomfile DROP CONSTRAINT organ_id;
       public          postgres    false    4744    233    218            �           2606    16479    organ organ_name_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.organ
    ADD CONSTRAINT organ_name_id FOREIGN KEY (organ_name_id) REFERENCES public.organname(organ_name_id);
 =   ALTER TABLE ONLY public.organ DROP CONSTRAINT organ_name_id;
       public          postgres    false    223    218    4750            �           2606    16502    texturemap segmentation_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.texturemap
    ADD CONSTRAINT segmentation_id FOREIGN KEY (segmentation_id) REFERENCES public.segmentation(segmentation_id) ON DELETE CASCADE;
 D   ALTER TABLE ONLY public.texturemap DROP CONSTRAINT segmentation_id;
       public          postgres    false    229    4756    227            �           2606    16545    segmentation slice_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.segmentation
    ADD CONSTRAINT slice_id FOREIGN KEY (slice_id) REFERENCES public.sliceimage(slice_id) ON DELETE CASCADE;
 ?   ALTER TABLE ONLY public.segmentation DROP CONSTRAINT slice_id;
       public          postgres    false    231    4758    229            �           2606    16540    organtag tag_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT tag_id FOREIGN KEY (tag_id) REFERENCES public.tag(tag_id) ON DELETE CASCADE;
 9   ALTER TABLE ONLY public.organtag DROP CONSTRAINT tag_id;
       public          postgres    false    221    4746    220            D      x������ � �      3   &   x�3�43�4202�50�5��t��t�5������ T�i      <      x������ � �      5      x�3�4�4����� �Z      :   ?   x�3��HM,*�2��)�K�2���L�K��2���,K-�2�t*J���2�.��ML������� �L�      8      x�3�4�2�4����� ��      @      x������ � �      B      x������ � �      7   S   x�3�t��t�5��2�t�LLJ-I-�2��OJ-�,��2��M��+-)�,����2��HM�)ɨ�2�t�I�����,������ :u<      >      x������ � �     